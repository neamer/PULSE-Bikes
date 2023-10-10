import 'package:json_annotation/json_annotation.dart';

part 'order_detail.g.dart';

@JsonSerializable()
class OrderDetail {
  int? productId;
  int? quantity;
  int? bicycleSizeId;

  OrderDetail();

  OrderDetail.build({this.productId, this.quantity, this.bicycleSizeId});

  factory OrderDetail.fromJson(Map<String, dynamic> json) =>
      _$OrderDetailFromJson(json);

  Map<String, dynamic> toJson() => _$OrderDetailToJson(this);
}
