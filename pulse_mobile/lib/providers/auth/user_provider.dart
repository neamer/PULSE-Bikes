import 'dart:convert';

import 'package:pulse_mobile/model/user/requests/registration_request.dart';
import 'package:pulse_mobile/model/user/user.dart';
import 'package:pulse_mobile/providers/abstract/base_crud_provider.dart';
import 'package:pulse_mobile/providers/abstract/base_provider.dart';

class UserProvider extends BaseCRUDProvider<User> {
  UserProvider() : super("Customer");

  @override
  User fromJson(data) {
    return User.fromJson(data);
  }

  Future<User?> register(RegistrationRequest request) async {
    var url = "${BaseProvider.baseUrl}$endpoint";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var jsonRequest = jsonEncode(request);
    var response = await http!.post(uri, headers: headers, body: jsonRequest);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      return null;
    }
  }

  Future login() async {
    var url = "${BaseProvider.baseUrl}$endpoint/login";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var response = await http!.post(uri, headers: headers);

    if (isValidResponseCode(response)) {
      return;
    } else {
      throw Exception("Wrong username or password");
    }
  }
}
