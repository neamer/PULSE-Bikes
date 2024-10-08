import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_mobile/model/product_category/product_category.dart';
import 'package:pulse_mobile/model/product_image/product_image.dart';

import '../brand/brand.dart';
import 'auditable_model.dart';

part 'product.g.dart';

@JsonSerializable()
class Product extends AuditableModel {
  int? brandId;
  int? productCategoryId;
  String? productNumber;
  String? model;
  String? description;
  String? discriminator;
  ProductCategory? productCategory;
  Brand? brand;
  double? price;
  List<ProductImage>? images;

  Product();

  factory Product.fromJson(Map<String, dynamic> json) =>
      _$ProductFromJson(json);

  Map<String, dynamic> toJson() => _$ProductToJson(this);

  @override
  String toString() {
    return "$brand $model";
  }
}

enum ProductType { Bicycle, Gear, Part }
