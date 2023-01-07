import 'package:pulse_mobile/model/product_category/product_category.dart';

import '../brand/brand.dart';

class Product {
  int? productId;
  int? brandId;
  int? productCategoryId;
  String? productNumber;
  String? model;
  String? description;
  ProductCategory? productCategory;
  Brand? brand;
  double? price;
  DateTime? createdAt;
  DateTime? updatedAt;

  Product();
}

enum ProductType { Bicycle, Gear, Part }
