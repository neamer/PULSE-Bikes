// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'stats.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Stats _$StatsFromJson(Map<String, dynamic> json) => Stats()
  ..year = json['year'] as int?
  ..month = json['month'] as int?
  ..value = (json['value'] as num?)?.toDouble();

Map<String, dynamic> _$StatsToJson(Stats instance) => <String, dynamic>{
      'year': instance.year,
      'month': instance.month,
      'value': instance.value,
    };
