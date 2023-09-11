// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'bicycle.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Bicycle _$BicycleFromJson(Map<String, dynamic> json) => Bicycle()
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
  ..weight = (json['weight'] as num?)?.toDouble()
  ..productionYear = json['productionYear'] as int?
  ..wheelSize = json['wheelSize'] as String?
  ..availableSizes = (json['availableSizes'] as List<dynamic>?)
      ?.map((e) => AvailableSize.fromJson(e as Map<String, dynamic>))
      .toList();

Map<String, dynamic> _$BicycleToJson(Bicycle instance) => <String, dynamic>{
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
      'weight': instance.weight,
      'productionYear': instance.productionYear,
      'wheelSize': instance.wheelSize,
      'availableSizes': instance.availableSizes,
    };
