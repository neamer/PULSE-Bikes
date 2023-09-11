import 'package:json_annotation/json_annotation.dart';

import '../abstract/base_model.dart';

part 'bicycle_size.g.dart';

@JsonSerializable()
class BicycleSize extends BaseModel {
  String? size;

  BicycleSize();

  factory BicycleSize.fromJson(Map<String, dynamic> json) =>
      _$BicycleSizeFromJson(json);

  Map<String, dynamic> toJson() => _$BicycleSizeToJson(this);

  @override
  String toString() => size ?? "";
}
