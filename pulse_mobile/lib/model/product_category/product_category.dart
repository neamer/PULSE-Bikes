import 'package:json_annotation/json_annotation.dart';

import '../abstract/base_model.dart';

part 'product_category.g.dart';

@JsonSerializable()
class ProductCategory extends BaseModel {
  String? name;

  ProductCategory();

  factory ProductCategory.fromJson(Map<String, dynamic> json) =>
      _$ProductCategoryFromJson(json);

  Map<String, dynamic> toJson() => _$ProductCategoryToJson(this);

  @override
  String toString() => name ?? "";
}
