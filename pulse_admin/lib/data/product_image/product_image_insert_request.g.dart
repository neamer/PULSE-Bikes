// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'product_image_insert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ProductImageInsertRequest _$ProductImageInsertRequestFromJson(
        Map<String, dynamic> json) =>
    ProductImageInsertRequest()
      ..productId = json['productId'] as int?
      ..data = json['data'] as String?;

Map<String, dynamic> _$ProductImageInsertRequestToJson(
        ProductImageInsertRequest instance) =>
    <String, dynamic>{
      'productId': instance.productId,
      'data': instance.data,
    };
