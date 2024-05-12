// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'staff.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Staff _$StaffFromJson(Map<String, dynamic> json) => Staff()
  ..id = json['id'] as int?
  ..firstName = json['firstName'] as String?
  ..lastName = json['lastName'] as String?
  ..username = json['username'] as String?
  ..email = json['email'] as String?
  ..phoneNumber = json['phoneNumber'] as String?
  ..dateOfBirth = json['dateOfBirth'] == null
      ? null
      : DateTime.parse(json['dateOfBirth'] as String)
  ..dateOfEmployment = json['dateOfEmployment'] == null
      ? null
      : DateTime.parse(json['dateOfEmployment'] as String)
  ..role = json['role'] == null
      ? null
      : Role.fromJson(json['role'] as Map<String, dynamic>)
  ..status = json['status'] as bool?;

Map<String, dynamic> _$StaffToJson(Staff instance) => <String, dynamic>{
      'id': instance.id,
      'firstName': instance.firstName,
      'lastName': instance.lastName,
      'username': instance.username,
      'email': instance.email,
      'phoneNumber': instance.phoneNumber,
      'dateOfBirth': instance.dateOfBirth?.toIso8601String(),
      'dateOfEmployment': instance.dateOfEmployment?.toIso8601String(),
      'role': instance.role,
      'status': instance.status,
    };
