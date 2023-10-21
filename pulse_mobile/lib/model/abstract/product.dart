import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_mobile/model/product_category/product_category.dart';

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

  Product();
}

enum ProductType { Bicycle, Gear, Part }
