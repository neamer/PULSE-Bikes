import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/data/user/role.dart';

part 'user.g.dart';

@JsonSerializable()
class User {
  int? id;
  String? firstName;
  String? lastName;
  String? username;
  String? email;
  String? phoneNumber;
  DateTime? dateOfBirth;
  DateTime? dateOfEmployment;
  Role? role;

  User();

  factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);

  Map<String, dynamic> toJson() => _$UserToJson(this);
}
