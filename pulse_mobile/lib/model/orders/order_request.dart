import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_mobile/model/generic/shipping_info.dart';
import 'package:pulse_mobile/model/payment/payment_insert_request.dart';

part 'order_request.g.dart';

@JsonSerializable()
class OrderRequest {
  ShippingInfo? shippingInfo;
  PaymentInsertRequest? payment;

  OrderRequest();

  OrderRequest.build({this.shippingInfo, this.payment});

  factory OrderRequest.fromJson(Map<String, dynamic> json) =>
      _$OrderRequestFromJson(json);

  Map<String, dynamic> toJson() => _$OrderRequestToJson(this);
}
