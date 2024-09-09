import 'dart:convert';

class HttpConfig {
  static const url = "http://localhost:6543/";
}

class Authorization {
  static String? username;
  static String? password;
}

Map<String, String> createHeaders() {
  String? username = Authorization.username;
  String? password = Authorization.password;

  String basicAuth =
      "Basic ${base64Encode(utf8.encode('$username:$password'))}";

  var headers = {
    "Content-Type": "application/json",
    "Authorization": basicAuth,
    "X-User-Type": "STAFF"
  };
  return headers;
}
