// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'gear_upsert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

GearUpsertRequest _$GearUpsertRequestFromJson(Map<String, dynamic> json) =>
    GearUpsertRequest()
      ..productNumber = json['productNumber'] as String?
      ..brandId = json['brandId'] as int?
      ..productCategoryId = json['productCategoryId'] as int?
      ..model = json['model'] as String?
      ..description = json['description'] as String?
      ..price = (json['price'] as num?)?.toDouble()
      ..availableQty = json['availableQty'] as int?;

Map<String, dynamic> _$GearUpsertRequestToJson(GearUpsertRequest instance) =>
    <String, dynamic>{
      'productNumber': instance.productNumber,
      'brandId': instance.brandId,
      'productCategoryId': instance.productCategoryId,
      'model': instance.model,
      'description': instance.description,
      'price': instance.price,
      'availableQty': instance.availableQty,
    };
