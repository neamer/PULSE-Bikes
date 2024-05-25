// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'staff_update_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

StaffUpdateRequest _$StaffUpdateRequestFromJson(Map<String, dynamic> json) =>
    StaffUpdateRequest()
      ..firstName = json['firstName'] as String?
      ..lastName = json['lastName'] as String?
      ..email = json['email'] as String?
      ..phoneNumber = json['phoneNumber'] as String?;

Map<String, dynamic> _$StaffUpdateRequestToJson(StaffUpdateRequest instance) =>
    <String, dynamic>{
      'firstName': instance.firstName,
      'lastName': instance.lastName,
      'email': instance.email,
      'phoneNumber': instance.phoneNumber,
    };
