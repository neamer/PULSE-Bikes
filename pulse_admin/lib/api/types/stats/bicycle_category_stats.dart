import 'package:json_annotation/json_annotation.dart';

part 'bicycle_category_stats.g.dart';

@JsonSerializable()
class BicycleCategoryStats {
  int? categoryId;
  double? value;

  BicycleCategoryStats();

  factory BicycleCategoryStats.fromJson(Map<String, dynamic> json) =>
      _$BicycleCategoryStatsFromJson(json);

  Map<String, dynamic> toJson() => _$BicycleCategoryStatsToJson(this);
}
