import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_mobile/model/bicycle_size/bicycle_size.dart';

part 'available_size.g.dart';

@JsonSerializable()
class AvailableSize {
  int? bicycleSizeId;
  int? productId;
  int? availableQty;
  BicycleSize? bicycleSize;

  AvailableSize();

  factory AvailableSize.fromJson(Map<String, dynamic> json) =>
      _$AvailableSizeFromJson(json);

  Map<String, dynamic> toJson() => _$AvailableSizeToJson(this);
}
