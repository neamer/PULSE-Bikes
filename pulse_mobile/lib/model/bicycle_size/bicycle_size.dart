import 'package:json_annotation/json_annotation.dart';

part 'bicycle_size.g.dart';

@JsonSerializable()
class BicycleSize {
  int? bicycleSizeId;
  String? size;

  BicycleSize();

  factory BicycleSize.fromJson(Map<String, dynamic> json) =>
      _$BicycleSizeFromJson(json);

  Map<String, dynamic> toJson() => _$BicycleSizeToJson(this);

  @override
  String toString() => size ?? "";
}
