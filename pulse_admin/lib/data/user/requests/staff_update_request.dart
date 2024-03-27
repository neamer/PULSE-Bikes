import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/model/forms/staff_form_field_names.dart';

part 'staff_update_request.g.dart';

@JsonSerializable()
class StaffUpdateRequest {
  String? firstName;
  String? lastName;
  String? email;
  String? phoneNumber;

  StaffUpdateRequest();

  factory StaffUpdateRequest.fromJson(Map<String, dynamic> json) =>
      _$StaffUpdateRequestFromJson(json);

  Map<String, dynamic> toJson() => _$StaffUpdateRequestToJson(this);

  StaffUpdateRequest.fromFormData(Map<String, dynamic> formData) {
    firstName = formData[StaffFormFieldNames.firstName];
    lastName = formData[StaffFormFieldNames.lastName];
    email = formData[StaffFormFieldNames.email];
    phoneNumber = formData[StaffFormFieldNames.phoneNumber];
  }
}
