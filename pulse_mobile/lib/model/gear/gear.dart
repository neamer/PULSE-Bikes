import 'package:json_annotation/json_annotation.dart';

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
}
