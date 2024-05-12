import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/data/product_image/product_image.dart';

import '../brand/brand.dart';
import '../abstract/product.dart';
import '../product_category/product_category.dart';

part 'part.g.dart';

@JsonSerializable()
class Part extends Product {
  static const String discriminator = "Part";
  int? availableQty;

  Part();

  factory Part.fromJson(Map<String, dynamic> json) => _$PartFromJson(json);

  Map<String, dynamic> toJson() => _$PartToJson(this);

  bool isAvailable() {
    return (availableQty ?? 0) > 0;
  }

  String getDiscriminator() => discriminator;
}
