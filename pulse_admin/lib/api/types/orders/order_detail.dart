import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/abstract/base_model.dart';
import 'package:pulse_admin/api/types/abstract/product.dart';
import 'package:pulse_admin/api/types/available_size/available_size.dart';
import 'package:pulse_admin/api/types/bicycle_size/bicycle_size.dart';

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

  OrderDetail.fromProduct(Product source, AvailableSize? size) {
    quantity = 1;
    product = source;
    productId = source.id;
    unitPrice = source.price;
    discriminator = source.getDiscriminator();

    if (size != null) {
      bicycleSizeId = size.bicycleSizeId;
      bicycleSize = size.bicycleSize;
    }
  }

  factory OrderDetail.fromJson(Map<String, dynamic> json) =>
      _$OrderDetailFromJson(json);

  Map<String, dynamic> toJson() => _$OrderDetailToJson(this);

  double total() {
    return unitPrice != null && quantity != null ? unitPrice! * quantity! : 0;
  }
}
