import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_mobile/model/product_image/product_image.dart';

import '../brand/brand.dart';
import '../abstract/product.dart';
import '../product_category/product_category.dart';

part 'gear.g.dart';

@JsonSerializable()
class Gear extends Product {
  int? availableQty;

  Gear();

  factory Gear.fromJson(Map<String, dynamic> json) => _$GearFromJson(json);

  Map<String, dynamic> toJson() => _$GearToJson(this);

  bool isAvailable() {
    return (availableQty ?? 0) > 0;
  }
}
