import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/generic/shipping_info.dart';

part 'order_request.g.dart';

@JsonSerializable()
class OrderRequest {
  ShippingInfo? shippingInfo;

  OrderRequest();

  OrderRequest.build({this.shippingInfo});

  factory OrderRequest.fromJson(Map<String, dynamic> json) =>
      _$OrderRequestFromJson(json);

  Map<String, dynamic> toJson() => _$OrderRequestToJson(this);
}
