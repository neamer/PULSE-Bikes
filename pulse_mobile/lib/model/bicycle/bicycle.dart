import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_mobile/model/available_size/available_size.dart';
import 'package:pulse_mobile/model/product_image/product_image.dart';

import '../brand/brand.dart';
import '../abstract/product.dart';
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

  bool isAvailable() {
    return (availableSizes
                ?.map((e) => e.availableQty ?? 0)
                .reduce((a, b) => a + b) ??
            0) >
        0;
  }
}
