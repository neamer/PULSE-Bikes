import 'dart:io';

import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/utils/image_util.dart';

part 'product_image_insert_request.g.dart';

@JsonSerializable()
class ProductImageInsertRequest {
  int? productId;
  String? data;

  ProductImageInsertRequest();

  factory ProductImageInsertRequest.fromJson(Map<String, dynamic> json) =>
      _$ProductImageInsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$ProductImageInsertRequestToJson(this);

  ProductImageInsertRequest.fromFile(File file, int id) {
    data = ImageUtil.base64StringFromFile(file);
    productId = id;
  }
}
