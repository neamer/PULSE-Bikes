// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'bicycle_upsert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

BicycleUpsertRequest _$BicycleUpsertRequestFromJson(
        Map<String, dynamic> json) =>
    BicycleUpsertRequest()
      ..productNumber = json['productNumber'] as String?
      ..brandId = json['brandId'] as int?
      ..productCategoryId = json['productCategoryId'] as int?
      ..model = json['model'] as String?
      ..description = json['description'] as String?
      ..price = (json['price'] as num?)?.toDouble()
      ..weight = (json['weight'] as num?)?.toDouble()
      ..productionYear = json['productionYear'] as int?
      ..wheelSize = json['wheelSize'] as String?;

Map<String, dynamic> _$BicycleUpsertRequestToJson(
        BicycleUpsertRequest instance) =>
    <String, dynamic>{
      'productNumber': instance.productNumber,
      'brandId': instance.brandId,
      'productCategoryId': instance.productCategoryId,
      'model': instance.model,
      'description': instance.description,
      'price': instance.price,
      'weight': instance.weight,
      'productionYear': instance.productionYear,
      'wheelSize': instance.wheelSize,
    };
