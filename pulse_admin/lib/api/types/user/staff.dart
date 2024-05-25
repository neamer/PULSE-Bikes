import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/user/role.dart';

part 'staff.g.dart';

enum StaffRole { administrator, mechanic, storekeeper, salesperson }

extension Name on StaffRole {
  String getRoleName() {
    return "${name.substring(0, 1).toUpperCase()}${name.substring(1)}";
  }
}

@JsonSerializable()
class Staff {
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

  Staff();

  factory Staff.fromJson(Map<String, dynamic> json) => _$StaffFromJson(json);

  Map<String, dynamic> toJson() => _$StaffToJson(this);

  @override
  String toString() => "$firstName $lastName";

  StaffRole getStaffRole() {
    switch (role?.name) {
      case "Administrator":
        return StaffRole.administrator;
      case "Mechanic":
        return StaffRole.mechanic;
      case "Storekeeper":
        return StaffRole.storekeeper;
      case "Salesperson":
        return StaffRole.salesperson;
      default:
        return StaffRole.salesperson;
    }
  }

  bool hasRole(StaffRole role) {
    switch (role) {
      case StaffRole.administrator:
        return this.role?.name == "Administrator";
      case StaffRole.mechanic:
        return this.role?.name == "Mechanic";
      case StaffRole.storekeeper:
        return this.role?.name == "Storekeeper";
      case StaffRole.salesperson:
        return this.role?.name == "Salesperson";
      default:
        return false;
    }
  }
}
