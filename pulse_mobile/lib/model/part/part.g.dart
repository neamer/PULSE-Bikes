// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'part.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Part _$PartFromJson(Map<String, dynamic> json) => Part()
  ..id = json['id'] as int?
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
  ..price = (json['price'] as num?)?.toDouble()
  ..createdAt = json['createdAt'] == null
      ? null
      : DateTime.parse(json['createdAt'] as String)
  ..updatedAt = json['updatedAt'] == null
      ? null
      : DateTime.parse(json['updatedAt'] as String)
  ..availableQty = json['availableQty'] as int?;

Map<String, dynamic> _$PartToJson(Part instance) => <String, dynamic>{
      'id': instance.id,
      'brandId': instance.brandId,
      'productCategoryId': instance.productCategoryId,
      'productNumber': instance.productNumber,
      'model': instance.model,
      'description': instance.description,
      'productCategory': instance.productCategory,
      'brand': instance.brand,
      'price': instance.price,
      'createdAt': instance.createdAt?.toIso8601String(),
      'updatedAt': instance.updatedAt?.toIso8601String(),
      'availableQty': instance.availableQty,
    };
