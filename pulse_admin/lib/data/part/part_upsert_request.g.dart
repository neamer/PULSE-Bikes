// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'part_upsert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

PartUpsertRequest _$PartUpsertRequestFromJson(Map<String, dynamic> json) =>
    PartUpsertRequest()
      ..productNumber = json['productNumber'] as String?
      ..brandId = json['brandId'] as int?
      ..productCategoryId = json['productCategoryId'] as int?
      ..model = json['model'] as String?
      ..description = json['description'] as String?
      ..price = (json['price'] as num?)?.toDouble()
      ..availableQty = json['availableQty'] as int?;

Map<String, dynamic> _$PartUpsertRequestToJson(PartUpsertRequest instance) =>
    <String, dynamic>{
      'productNumber': instance.productNumber,
      'brandId': instance.brandId,
      'productCategoryId': instance.productCategoryId,
      'model': instance.model,
      'description': instance.description,
      'price': instance.price,
      'availableQty': instance.availableQty,
    };
