import 'package:json_annotation/json_annotation.dart';

part 'brand_upsert_request.g.dart';

class BrandUpsertRequestFieldNames {
  static const String name = "name";
}

@JsonSerializable()
class BrandUpsertRequest {
  String? name;

  BrandUpsertRequest();

  factory BrandUpsertRequest.fromJson(Map<String, dynamic> json) =>
      _$BrandUpsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$BrandUpsertRequestToJson(this);

  BrandUpsertRequest.fromFormData(Map<String, dynamic> formData) {
    name = formData[BrandUpsertRequestFieldNames.name];
  }
}
