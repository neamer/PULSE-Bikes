// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'available_size_insert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

AvailableSizeInsertRequest _$AvailableSizeInsertRequestFromJson(
        Map<String, dynamic> json) =>
    AvailableSizeInsertRequest()
      ..productId = json['productId'] as int?
      ..bicycleSizeId = json['bicycleSizeId'] as int?
      ..availableQty = json['availableQty'] as int?;

Map<String, dynamic> _$AvailableSizeInsertRequestToJson(
        AvailableSizeInsertRequest instance) =>
    <String, dynamic>{
      'productId': instance.productId,
      'bicycleSizeId': instance.bicycleSizeId,
      'availableQty': instance.availableQty,
    };
