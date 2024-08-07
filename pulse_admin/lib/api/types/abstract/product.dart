import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/product_category/product_category.dart';
import 'package:pulse_admin/api/types/product_image/product_image.dart';

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
    return "$model";
  }

  String getDiscriminator() => "NOT ALLOWED";
}

enum ProductType { Bicycle, Gear, Part }
