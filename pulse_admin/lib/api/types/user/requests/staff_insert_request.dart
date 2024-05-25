import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/user/role.dart';
import 'package:pulse_admin/domain/types/forms/staff_form_field_names.dart';

part 'staff_insert_request.g.dart';

@JsonSerializable()
class StaffInsertRequest {
  String? firstName;
  String? lastName;
  String? username;
  String? email;
  String? password;
  String? passwordConfirm;
  int? roleID;
  String? phoneNumber;
  DateTime? dateOfBirth;
  DateTime? dateOfEmployment;

  StaffInsertRequest();

  factory StaffInsertRequest.fromJson(Map<String, dynamic> json) =>
      _$StaffInsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$StaffInsertRequestToJson(this);

  StaffInsertRequest.fromFormData(Map<String, dynamic> formData) {
    firstName = formData[StaffFormFieldNames.firstName];
    lastName = formData[StaffFormFieldNames.lastName];
    username = formData[StaffFormFieldNames.username];
    email = formData[StaffFormFieldNames.email];
    password = formData[StaffFormFieldNames.password];
    passwordConfirm = formData[StaffFormFieldNames.passwordConfirm];
    roleID = (formData[StaffFormFieldNames.role] as Role).id;
    phoneNumber = formData[StaffFormFieldNames.phoneNumber];
    dateOfBirth = formData[StaffFormFieldNames.dateOfBirth];
    dateOfEmployment = formData[StaffFormFieldNames.dateOfEmployment];
    print("RoleID: $roleID");
  }
}
