// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'staff_insert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

StaffInsertRequest _$StaffInsertRequestFromJson(Map<String, dynamic> json) =>
    StaffInsertRequest()
      ..firstName = json['firstName'] as String?
      ..lastName = json['lastName'] as String?
      ..username = json['username'] as String?
      ..email = json['email'] as String?
      ..password = json['password'] as String?
      ..passwordConfirm = json['passwordConfirm'] as String?
      ..roleID = json['roleID'] as int?
      ..phoneNumber = json['phoneNumber'] as String?
      ..dateOfBirth = json['dateOfBirth'] == null
          ? null
          : DateTime.parse(json['dateOfBirth'] as String)
      ..dateOfEmployment = json['dateOfEmployment'] == null
          ? null
          : DateTime.parse(json['dateOfEmployment'] as String);

Map<String, dynamic> _$StaffInsertRequestToJson(StaffInsertRequest instance) =>
    <String, dynamic>{
      'firstName': instance.firstName,
      'lastName': instance.lastName,
      'username': instance.username,
      'email': instance.email,
      'password': instance.password,
      'passwordConfirm': instance.passwordConfirm,
      'roleID': instance.roleID,
      'phoneNumber': instance.phoneNumber,
      'dateOfBirth': instance.dateOfBirth?.toIso8601String(),
      'dateOfEmployment': instance.dateOfEmployment?.toIso8601String(),
    };
