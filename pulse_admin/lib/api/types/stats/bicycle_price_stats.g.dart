// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'bicycle_price_stats.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

BicyclePriceStats _$BicyclePriceStatsFromJson(Map<String, dynamic> json) =>
    BicyclePriceStats()
      ..range = json['range'] as int?
      ..value = (json['value'] as num?)?.toDouble();

Map<String, dynamic> _$BicyclePriceStatsToJson(BicyclePriceStats instance) =>
    <String, dynamic>{
      'range': instance.range,
      'value': instance.value,
    };
