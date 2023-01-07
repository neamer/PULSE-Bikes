// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'available_size.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

AvailableSize _$AvailableSizeFromJson(Map<String, dynamic> json) =>
    AvailableSize()
      ..bicycleSizeId = json['bicycleSizeId'] as int?
      ..productId = json['productId'] as int?
      ..availableQty = json['availableQty'] as int?
      ..bicycleSize = json['bicycleSize'] == null
          ? null
          : BicycleSize.fromJson(json['bicycleSize'] as Map<String, dynamic>);

Map<String, dynamic> _$AvailableSizeToJson(AvailableSize instance) =>
    <String, dynamic>{
      'bicycleSizeId': instance.bicycleSizeId,
      'productId': instance.productId,
      'availableQty': instance.availableQty,
      'bicycleSize': instance.bicycleSize,
    };
