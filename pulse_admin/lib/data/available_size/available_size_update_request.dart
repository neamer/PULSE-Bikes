import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/model/forms/available_size_form_field_names.dart';

part 'available_size_update_request.g.dart';

@JsonSerializable()
class AvailableSizeUpdateRequest {
  int? availableQty;

  AvailableSizeUpdateRequest();

  factory AvailableSizeUpdateRequest.fromJson(Map<String, dynamic> json) =>
      _$AvailableSizeUpdateRequestFromJson(json);

  Map<String, dynamic> toJson() => _$AvailableSizeUpdateRequestToJson(this);

  AvailableSizeUpdateRequest.fromFormData(Map<String, dynamic> formData) {
    availableQty = formData[AvailableSizeFormFieldNames.availableQty];
  }
}
