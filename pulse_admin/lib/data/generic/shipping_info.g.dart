// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'shipping_info.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ShippingInfo _$ShippingInfoFromJson(Map<String, dynamic> json) => ShippingInfo()
  ..country = json['country'] as String?
  ..state = json['state'] as String?
  ..city = json['city'] as String?
  ..street = json['street'] as String?
  ..zipCode = json['zipCode'] as String?;

Map<String, dynamic> _$ShippingInfoToJson(ShippingInfo instance) =>
    <String, dynamic>{
      'country': instance.country,
      'state': instance.state,
      'city': instance.city,
      'street': instance.street,
      'zipCode': instance.zipCode,
    };
