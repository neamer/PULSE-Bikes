// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'available_size.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

AvailableSize _$AvailableSizeFromJson(Map<String, dynamic> json) =>
    AvailableSize()
      ..id = json['id'] as int?
      ..bicycleSizeId = json['bicycleSizeId'] as int?
      ..productId = json['productId'] as int?
      ..availableQty = json['availableQty'] as int?
      ..bicycleSize = json['bicycleSize'] == null
          ? null
          : BicycleSize.fromJson(json['bicycleSize'] as Map<String, dynamic>);

Map<String, dynamic> _$AvailableSizeToJson(AvailableSize instance) =>
    <String, dynamic>{
      'id': instance.id,
      'bicycleSizeId': instance.bicycleSizeId,
      'productId': instance.productId,
      'availableQty': instance.availableQty,
      'bicycleSize': instance.bicycleSize,
    };
