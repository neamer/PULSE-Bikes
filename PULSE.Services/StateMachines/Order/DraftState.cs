using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Order
{
    public class DraftState : BaseState
    {
        public DraftState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }

        public override Model.OrderHeader Update(OrderHeaderUpdateRequest request)
        {
            if (CurrentEntity != null)
            {
                if(request.Delivery)
                {
                    if(CurrentEntity.ShippingInfoId == null) // ADD SHIPPING INFO
                    {
                        var shippingInfo = new ShippingInfo()
                        {
                            Country = request.ShippingInfo.Country,
                            StateOrProvince = request.ShippingInfo.StateOrProvince,
                            City = request.ShippingInfo.City,
                            ZipCode = request.ShippingInfo.ZipCode,
                            StreetAddress = request.ShippingInfo.StreetAddress
                        };

                        Context.ShippingInfos.Add(shippingInfo);
                        Context.SaveChanges();

                        CurrentEntity.ShippingInfoId = shippingInfo.Id;
                    }
                    else // UPDATE SHIPPING INFO
                    {
                        var shippingInfo = Context.ShippingInfos.Find(CurrentEntity.ShippingInfoId);

                        shippingInfo.Country = request.ShippingInfo.Country;
                        shippingInfo.StateOrProvince = request.ShippingInfo.StateOrProvince;
                        shippingInfo.City = request.ShippingInfo.City;
                        shippingInfo.ZipCode = request.ShippingInfo.ZipCode;
                        shippingInfo.StreetAddress = request.ShippingInfo.StreetAddress;

                        Context.SaveChanges();
                    }
                }

                Mapper.Map(request, CurrentEntity);
            }
            else
            {
                return null;
            }

            Context.SaveChanges();

            return Mapper.Map<Model.OrderHeader>(CurrentEntity);
        }

        public override Model.OrderDetail AddBicycleDetail(OrderDetailBicycleInsertRequest req)
        {
            var detailProduct = Context.Bicycles.Find(req.ProductId);
            var detailSize = Context.AvailableSizes.Find(req.BicycleSizeId, req.ProductId);

            if (detailProduct != null && detailSize != null)
            {
                var detail = Mapper.Map<OrderDetailBicycle>(req);
                detail.OrderId = CurrentEntity.Id;
                detail.UnitPrice = detailProduct.Price;
                Context.OrderDetailBicycles.Add(detail);
                Context.SaveChanges();

                return Mapper.Map<Model.OrderDetail>(detail);
            }

            return null;
        }

        public override Model.OrderDetail AddGearDetail(OrderDetailsInsertRequest item)
        {
            var detailProduct = Context.Gear.Find(item.ProductId);
            if (detailProduct != null)
            {
                var detail = Mapper.Map<OrderDetailGear>(item);
                detail.OrderId = CurrentEntity.Id;
                detail.UnitPrice = detailProduct.Price;
                Context.OrderDetailGear.Add(detail);
                Context.SaveChanges();

                return Mapper.Map<Model.OrderDetail>(detail);
            }

            return null;
        }

        public override Model.OrderDetail AddPartDetail(OrderDetailsInsertRequest item)
        {
            var detailProduct = Context.Parts.Find(item.ProductId);
            if (detailProduct != null)
            {
                var detail = Mapper.Map<OrderDetailPart>(item);
                detail.OrderId = CurrentEntity.Id;
                detail.UnitPrice = detailProduct.Price;
                Context.OrderDetailParts.Add(detail);
                Context.SaveChanges();
                return Mapper.Map<Model.OrderDetail>(detail);
            }

            return null;
        }

        public override Model.OrderDetail UpdateOrderDetail(int id, OrderDetailsUpdateRequest req)
        {
            var item = Context.OrderDetail.Find(id);

            if(item != null)
            {
                Mapper.Map(req, item);

                Context.SaveChanges();

                return Mapper.Map<Model.OrderDetail>(item);
            }
             
            return null;
        }

        public override Model.OrderDetail DeleteOrderDetail(int id)
        {
            var item = Context.OrderDetail.Find(id);

            if (item != null)
            {
                Context.Remove(item);

                Context.SaveChanges();

                return Mapper.Map<Model.OrderDetail>(item);
            }

            return null;
        }

        public override bool DeleteShippingInfo()
        {
            CurrentEntity.ShippingInfoId = null;
            CurrentEntity.Delivery = false;
            Context.Remove(CurrentEntity.ShippingInfo);

            Context.SaveChanges();

            return true;
        }

        public override Model.OrderHeader Delete()
        {
            if(CurrentEntity == null) { return null; }

            Context.Remove(CurrentEntity);

            Context.SaveChanges();

            return Mapper.Map<Model.OrderHeader>(CurrentEntity);
        }

        public override bool Process(PaymentInsertRequest req)
        {
            if(Helpers.ValidateOrder(Context, CurrentEntity.OrderDetails))
            {
                decimal totalPrice = 0;

                foreach (var item in CurrentEntity.OrderDetails)
                {
                    totalPrice += (item.UnitPrice ?? 0) * (item.Quantity ?? 0);

                    switch (item.Discriminator)
                    {
                        case "Part":

                            var detailProductP = Context.Parts.Find(item.ProductId);

                            if (detailProductP != null && detailProductP.AvailableQty - item.Quantity >= 0)
                            {
                                var detailP = Mapper.Map<OrderDetailPart>(item);
                                detailP.OrderId = CurrentEntity.Id;
                                detailP.UnitPrice = detailProductP.Price;
                                detailProductP.AvailableQty -= detailP.Quantity;
                                Context.SaveChanges();
                            }
                            break;

                        case "Gear":
                            var detailProductG = Context.Gear.Find(item.ProductId);

                            if (detailProductG != null && detailProductG.AvailableQty - item.Quantity >= 0)
                            {
                                var detailG = Mapper.Map<OrderDetailGear>(item);
                                detailG.OrderId = CurrentEntity.Id;
                                detailG.UnitPrice = detailProductG.Price;
                                detailProductG.AvailableQty -= detailG.Quantity;
                                Context.SaveChanges();
                            }
                            break;

                        case "Bicycle":
                            var detailProductB = Context.Bicycles.Find(item.ProductId);
                            var detailSize = Context.AvailableSizes.Find((item as OrderDetailBicycle).BicycleSizeId, item.ProductId);

                            if (detailProductB != null && detailSize != null && detailSize.AvailableQty - item.Quantity >= 0)
                            {
                                var detailB = Mapper.Map<OrderDetailBicycle>(item);
                                detailB.OrderId = CurrentEntity.Id;
                                detailB.UnitPrice = detailProductB.Price;
                                detailSize.AvailableQty -= detailB.Quantity;
                                Context.SaveChanges();
                            }
                            break;
                        default:
                            break;
                    }
                }

                if(CurrentEntity.Delivery == true)
                {
                    totalPrice += CurrentEntity.ShippingConst ?? 0;
                }

                var payment = Mapper.Map<Payment>(req);
                payment.TimeOfPayment = DateTime.Now;
                payment.Amount = totalPrice;

                Context.Payments.Add(payment);
                Context.SaveChanges();

                CurrentEntity.Status = Model.OrderState.Processed;
                CurrentEntity.TimeProcessed = DateTime.Now;
                CurrentEntity.PaymentId = payment.Id;

                Context.SaveChanges();

                return true;
            }

            return false;
        }

        public override List<string> AllowedActions()
        {
            var list = base.AllowedActions();

            list.Add("Update");
            list.Add("Process");
            list.Add("Cancel");

            return list;
        }
    }
}
