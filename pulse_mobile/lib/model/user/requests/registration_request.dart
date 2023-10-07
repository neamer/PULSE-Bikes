import 'package:json_annotation/json_annotation.dart';

part 'registration_request.g.dart';

@JsonSerializable()
class RegistrationRequest {
  String? username;
  String? password;
  String? passwordConfirm;
  String? firstName;
  String? lastName;
  String? email;
  String? phoneNumber;

  RegistrationRequest();

  RegistrationRequest.init({
    required this.username,
    required this.password,
    required this.passwordConfirm,
    required this.firstName,
    required this.lastName,
    required this.email,
    required this.phoneNumber,
  });

  factory RegistrationRequest.fromJson(Map<String, dynamic> json) =>
      _$RegistrationRequestFromJson(json);

  Map<String, dynamic> toJson() => _$RegistrationRequestToJson(this);
}
