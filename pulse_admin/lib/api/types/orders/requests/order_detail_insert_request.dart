import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/orders/order_detail.dart';

part 'order_detail_insert_request.g.dart';

@JsonSerializable()
class OrderDetailInsertRequest {
  int? productId;
  int? quantity;
  int? bicycleSizeId;
  String? discriminator;

  OrderDetailInsertRequest();

  factory OrderDetailInsertRequest.fromJson(Map<String, dynamic> json) =>
      _$OrderDetailInsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$OrderDetailInsertRequestToJson(this);

  OrderDetailInsertRequest.fromOrderDetail(OrderDetail detail) {
    productId = detail.productId;
    quantity = detail.quantity;
    bicycleSizeId = detail.bicycleSizeId;
    discriminator = detail.discriminator;
  }
}
