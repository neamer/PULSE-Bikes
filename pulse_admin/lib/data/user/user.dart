import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/data/user/role.dart';

part 'user.g.dart';

enum UserRole { administrator, mechanic, storekeeper, salesperson }

extension Name on UserRole {
  String getRoleName() {
    return "${name.substring(0, 1).toUpperCase()}${name.substring(1)}";
  }
}

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
  bool? status;

  User();

  factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);

  Map<String, dynamic> toJson() => _$UserToJson(this);

  @override
  String toString() => "$firstName $lastName";

  UserRole getUserRole() {
    switch (role?.name) {
      case "Administrator":
        return UserRole.administrator;
      case "Mechanic":
        return UserRole.mechanic;
      case "Storekeeper":
        return UserRole.storekeeper;
      case "Salesperson":
        return UserRole.salesperson;
      default:
        return UserRole.salesperson;
    }
  }

  bool hasRole(UserRole role) {
    switch (role) {
      case UserRole.administrator:
        return this.role?.name == "Administrator";
      case UserRole.mechanic:
        return this.role?.name == "Mechanic";
      case UserRole.storekeeper:
        return this.role?.name == "Storekeeper";
      case UserRole.salesperson:
        return this.role?.name == "Salesperson";
      default:
        return false;
    }
  }
}
