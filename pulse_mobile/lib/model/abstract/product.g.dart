// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'product.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Product _$ProductFromJson(Map<String, dynamic> json) => Product()
  ..id = json['id'] as int?
  ..createdAt = json['createdAt'] == null
      ? null
      : DateTime.parse(json['createdAt'] as String)
  ..updatedAt = json['updatedAt'] == null
      ? null
      : DateTime.parse(json['updatedAt'] as String)
  ..brandId = json['brandId'] as int?
  ..productCategoryId = json['productCategoryId'] as int?
  ..productNumber = json['productNumber'] as String?
  ..model = json['model'] as String?
  ..description = json['description'] as String?
  ..productCategory = json['productCategory'] == null
      ? null
      : ProductCategory.fromJson(
          json['productCategory'] as Map<String, dynamic>)
  ..brand = json['brand'] == null
      ? null
      : Brand.fromJson(json['brand'] as Map<String, dynamic>)
  ..price = (json['price'] as num?)?.toDouble();

Map<String, dynamic> _$ProductToJson(Product instance) => <String, dynamic>{
      'id': instance.id,
      'createdAt': instance.createdAt?.toIso8601String(),
      'updatedAt': instance.updatedAt?.toIso8601String(),
      'brandId': instance.brandId,
      'productCategoryId': instance.productCategoryId,
      'productNumber': instance.productNumber,
      'model': instance.model,
      'description': instance.description,
      'productCategory': instance.productCategory,
      'brand': instance.brand,
      'price': instance.price,
    };
