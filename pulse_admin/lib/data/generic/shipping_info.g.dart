// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'shipping_info.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ShippingInfo _$ShippingInfoFromJson(Map<String, dynamic> json) => ShippingInfo()
  ..country = json['country'] as String?
  ..stateOrProvince = json['stateOrProvince'] as String?
  ..city = json['city'] as String?
  ..streetAddress = json['streetAddress'] as String?
  ..zipCode = json['zipCode'] as String?;

Map<String, dynamic> _$ShippingInfoToJson(ShippingInfo instance) =>
    <String, dynamic>{
      'country': instance.country,
      'stateOrProvince': instance.stateOrProvince,
      'city': instance.city,
      'streetAddress': instance.streetAddress,
      'zipCode': instance.zipCode,
    };
