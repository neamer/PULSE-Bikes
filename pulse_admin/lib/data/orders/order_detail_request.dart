import 'package:json_annotation/json_annotation.dart';

part 'order_detail_request.g.dart';

@JsonSerializable()
class OrderDetailRequest {
  int? productId;
  int? quantity;
  int? bicycleSizeId;

  OrderDetailRequest();

  OrderDetailRequest.build({this.productId, this.quantity, this.bicycleSizeId});

  factory OrderDetailRequest.fromJson(Map<String, dynamic> json) =>
      _$OrderDetailRequestFromJson(json);

  Map<String, dynamic> toJson() => _$OrderDetailRequestToJson(this);
}
