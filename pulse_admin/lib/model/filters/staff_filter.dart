import 'package:pulse_admin/data/user/role.dart';
import 'package:pulse_admin/model/filters/abstract_filter.dart';

class StaffFilter implements Filter {
  final bool includeRole;
  String anyField = "";
  bool? status;
  Role? role;

  StaffFilter({required this.includeRole});

  @override
  Map<String, Object?> toQuery() {
    return {
      "IncludeRole": includeRole,
      "AnyField": anyField,
      "Status": status,
      "RoleId": role?.id
    };
  }
}
