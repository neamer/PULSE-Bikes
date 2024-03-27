import 'package:json_annotation/json_annotation.dart';

import '../abstract/base_model.dart';

part 'product_image.g.dart';

@JsonSerializable()
class ProductImage extends BaseModel {
  String? data;

  ProductImage();

  factory ProductImage.fromJson(Map<String, dynamic> json) =>
      _$ProductImageFromJson(json);

  Map<String, dynamic> toJson() => _$ProductImageToJson(this);
}
