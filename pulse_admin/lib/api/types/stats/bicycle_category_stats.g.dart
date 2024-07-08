// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'bicycle_category_stats.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

BicycleCategoryStats _$BicycleCategoryStatsFromJson(
        Map<String, dynamic> json) =>
    BicycleCategoryStats()
      ..categoryId = json['categoryId'] as int?
      ..value = (json['value'] as num?)?.toDouble();

Map<String, dynamic> _$BicycleCategoryStatsToJson(
        BicycleCategoryStats instance) =>
    <String, dynamic>{
      'categoryId': instance.categoryId,
      'value': instance.value,
    };
