// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'product_image.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ProductImage _$ProductImageFromJson(Map<String, dynamic> json) => ProductImage()
  ..id = json['id'] as int?
  ..productId = json['productId'] as int?
  ..data = json['data'] as String?;

Map<String, dynamic> _$ProductImageToJson(ProductImage instance) =>
    <String, dynamic>{
      'id': instance.id,
      'productId': instance.productId,
      'data': instance.data,
    };
