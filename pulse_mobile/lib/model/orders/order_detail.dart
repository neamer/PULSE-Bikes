import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_mobile/model/abstract/base_model.dart';
import 'package:pulse_mobile/model/abstract/product.dart';
import 'package:pulse_mobile/model/bicycle_size/bicycle_size.dart';

part 'order_detail.g.dart';

@JsonSerializable()
class OrderDetail extends BaseModel {
  int? productId;
  int? quantity;
  int? bicycleSizeId;
  double? unitPrice;
  String? discriminator;
  BicycleSize? bicycleSize;
  Product? product;

  OrderDetail();

  factory OrderDetail.fromJson(Map<String, dynamic> json) =>
      _$OrderDetailFromJson(json);

  Map<String, dynamic> toJson() => _$OrderDetailToJson(this);
}
