import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:pulse_admin/core/auth/authorization.dart';
import 'package:pulse_admin/core/http/http_client.dart';
import 'package:pulse_admin/data/user/requests/login_request.dart';
import 'package:pulse_admin/data/user/user.dart';
import 'package:pulse_admin/utils/http_utils.dart';

class AuthProvider extends AbstractHttpClient with ChangeNotifier {
  User? user;

  void logout() {
    user = null;
    Authorization.username = null;
    Authorization.password = null;
  }

  Future<User?> login(LoginRequest request) async {
    var url = "${HttpConfig.url}staff/login";
    var uri = Uri.parse(url);

    Authorization.username = request.username;
    Authorization.password = request.password;

    Map<String, String> headers = createHeaders();
    var jsonRequest = jsonEncode(request);

    var response = await http!.post(uri, headers: headers, body: jsonRequest);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      user = User.fromJson(data);
      notifyListeners();
      return user;
    } else {
      return null;
    }
  }
}
