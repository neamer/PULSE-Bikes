import 'package:json_annotation/json_annotation.dart';

part 'shipping_info.g.dart';

@JsonSerializable()
class ShippingInfo {
  String? country;
  String? stateOrProvince;
  String? city;
  String? streetAddress;
  String? zipCode;

  ShippingInfo();

  ShippingInfo.build(
      {this.country,
      this.stateOrProvince,
      this.city,
      this.streetAddress,
      this.zipCode});

  factory ShippingInfo.fromJson(Map<String, dynamic> json) =>
      _$ShippingInfoFromJson(json);

  Map<String, dynamic> toJson() => _$ShippingInfoToJson(this);
}
