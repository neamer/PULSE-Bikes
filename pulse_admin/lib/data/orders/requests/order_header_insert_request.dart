import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/data/abstract/base_model.dart';
import 'package:pulse_admin/data/generic/shipping_info.dart';
import 'package:pulse_admin/data/orders/order_detail.dart';
import 'package:pulse_admin/data/orders/requests/order_detail_insert_request.dart';
import 'package:pulse_admin/data/user/customer.dart';
import 'package:pulse_admin/model/forms/order_form_field_names.dart';

part 'order_header_insert_request.g.dart';

@JsonSerializable()
class OrderHeaderInsertRequest extends BaseModel {
  String? orderNumber;
  int? customerId;
  bool? onlineOrder;
  bool? delivery;
  double? shippingConst;
  ShippingInfo? shippingInfo;
  List<OrderDetailInsertRequest> orderDetails = [];

  OrderHeaderInsertRequest();

  factory OrderHeaderInsertRequest.fromJson(Map<String, dynamic> json) =>
      _$OrderHeaderInsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$OrderHeaderInsertRequestToJson(this);

  OrderHeaderInsertRequest.fromFormData(Map<String, dynamic> formData) {
    orderNumber = formData[OrderFormFieldNames.orderNumber];
    customerId = (formData[OrderFormFieldNames.customer] as Customer).id;
    onlineOrder = false;
    delivery = formData[OrderFormFieldNames.delivery];
    shippingConst = formData[OrderFormFieldNames.shippingCost];

    orderDetails =
        (formData[OrderFormFieldNames.orderDetails] as List<OrderDetail>)
            .map((e) => OrderDetailInsertRequest.fromOrderDetail(e))
            .toList();

    if (delivery == true) {
      shippingInfo = ShippingInfo.build(
          country: formData[OrderFormFieldNames.country],
          stateOrProvince: formData[OrderFormFieldNames.state],
          city: formData[OrderFormFieldNames.city],
          streetAddress: formData[OrderFormFieldNames.address],
          zipCode: formData[OrderFormFieldNames.zipCode]);
    }
  }
}
