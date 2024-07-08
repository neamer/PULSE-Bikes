import 'package:json_annotation/json_annotation.dart';

part 'bicycle_price_stats.g.dart';

enum BicyclePriceStatsRange {
  to500,
  from500to1000,
  from1000to1500,
  from1500to2500,
  from2500to5000,
  from5000
}

@JsonSerializable()
class BicyclePriceStats {
  int? range;
  double? value;

  BicyclePriceStats();

  factory BicyclePriceStats.fromJson(Map<String, dynamic> json) =>
      _$BicyclePriceStatsFromJson(json);

  Map<String, dynamic> toJson() => _$BicyclePriceStatsToJson(this);
}
