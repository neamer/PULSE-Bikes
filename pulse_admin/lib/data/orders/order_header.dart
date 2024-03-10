import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/data/abstract/base_model.dart';
import 'package:pulse_admin/data/generic/shipping_info.dart';
import 'package:pulse_admin/data/orders/order_detail.dart';

part 'order_header.g.dart';

// Initial,
// Cart,
// Draft,
// Processed,
// Packed,
// Shipped,
// Collected,
// Delivered,
// Cancelled

@JsonSerializable()
class OrderHeader extends BaseModel {
  String? orderNumber;
  int? customerId;
  int? paymentId;
  int? shippingInfoId;
  int? status;
  String? statusName;
  String? statusNamee;
  DateTime? timeProcessed;
  DateTime? timePacked;
  DateTime? timeShipped;
  DateTime? timeDelivered;
  bool? onlineOrder;
  bool? delivery;
  double? shippingCost;
  int? noOfItems;
  double? total;
  ShippingInfo? shippingInfo;

  List<OrderDetail> orderDetails = [];

  OrderHeader();

  factory OrderHeader.fromJson(Map<String, dynamic> json) =>
      _$OrderHeaderFromJson(json);

  Map<String, dynamic> toJson() => _$OrderHeaderToJson(this);

  double getTotal() {
    double result = 0;

    orderDetails.forEach((element) => result += element.total());

    return result;
  }
}
