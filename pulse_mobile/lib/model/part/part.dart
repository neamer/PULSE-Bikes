import 'package:json_annotation/json_annotation.dart';

import '../brand/brand.dart';
import '../product/product.dart';
import '../product_category/product_category.dart';

part 'part.g.dart';

@JsonSerializable()
class Part extends Product {
  int? availableQty;

  Part();

  factory Part.fromJson(Map<String, dynamic> json) => _$PartFromJson(json);

  Map<String, dynamic> toJson() => _$PartToJson(this);
}
