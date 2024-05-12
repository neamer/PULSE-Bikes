import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/data/bicycle_size/bicycle_size.dart';

import '../abstract/base_model.dart';

part 'available_size.g.dart';

@JsonSerializable()
class AvailableSize extends BaseModel {
  int? bicycleSizeId;
  int? productId;
  int? availableQty;
  BicycleSize? bicycleSize;

  AvailableSize();

  factory AvailableSize.fromJson(Map<String, dynamic> json) =>
      _$AvailableSizeFromJson(json);

  Map<String, dynamic> toJson() => _$AvailableSizeToJson(this);

  @override
  String toString() => "$bicycleSize - ${availableQty.toString()} available";

  @override
  bool operator ==(covariant AvailableSize other) => id == other.id;

  @override
  int get hashCode => super.hashCode;
}
