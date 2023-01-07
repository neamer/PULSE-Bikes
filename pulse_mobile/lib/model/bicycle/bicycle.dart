import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_mobile/model/available_size/available_size.dart';

import '../brand/brand.dart';
import '../product/product.dart';
import '../product_category/product_category.dart';

part 'bicycle.g.dart';

@JsonSerializable()
class Bicycle extends Product {
  double? weight;
  int? productionYear;
  String? wheelSize;
  List<AvailableSize>? availableSizes;

  Bicycle();

  factory Bicycle.fromJson(Map<String, dynamic> json) =>
      _$BicycleFromJson(json);

  Map<String, dynamic> toJson() => _$BicycleToJson(this);
}
