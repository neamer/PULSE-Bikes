import 'package:json_annotation/json_annotation.dart';

part 'shipping_info.g.dart';

@JsonSerializable()
class ShippingInfo {
  String? country;
  String? state;
  String? city;
  String? street;
  String? zipCode;

  ShippingInfo();

  ShippingInfo.build({this.country, this.state, this.city, this.street, this.zipCode});

  factory ShippingInfo.fromJson(Map<String, dynamic> json) =>
      _$ShippingInfoFromJson(json);

  Map<String, dynamic> toJson() => _$ShippingInfoToJson(this);
}
