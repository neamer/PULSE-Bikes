import 'dart:convert';

import 'package:pulse_admin/api/providers/base/base_crud_provider.dart';
import 'package:pulse_admin/api/providers/base/base_provider.dart';
import 'package:pulse_admin/api/types/user/role.dart';
import 'package:pulse_admin/api/types/user/staff.dart';
import 'package:pulse_admin/core/auth/authorization.dart';
import 'package:pulse_admin/utils/http_utils.dart';

class StaffProvider extends BaseCRUDProvider<Staff> {
  StaffProvider() : super('Staff');

  @override
  Staff fromJson(data) {
    return Staff.fromJson(data);
  }

  Future<List<Role>> getRoles() async {
    var url = "${BaseProvider.baseUrl}Staff/Roles";

    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var response = await http!.get(uri, headers: headers);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data.map((x) => Role.fromJson(x)).cast<Role>().toList();
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }
}
