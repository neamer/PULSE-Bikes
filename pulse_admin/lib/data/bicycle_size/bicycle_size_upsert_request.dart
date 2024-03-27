import 'package:json_annotation/json_annotation.dart';

part 'bicycle_size_upsert_request.g.dart';

abstract class BicycleSizeUpsertRequestFieldNames {
  static const String size = "size";
}

@JsonSerializable()
class BicycleSizeUpsertRequest {
  String? size;

  BicycleSizeUpsertRequest();

  factory BicycleSizeUpsertRequest.fromJson(Map<String, dynamic> json) =>
      _$BicycleSizeUpsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$BicycleSizeUpsertRequestToJson(this);

  BicycleSizeUpsertRequest.fromFormData(Map<String, dynamic> formData) {
    size = formData[BicycleSizeUpsertRequestFieldNames.size];
  }
}
