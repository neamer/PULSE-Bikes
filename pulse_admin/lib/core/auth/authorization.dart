import 'dart:convert';

class Authorization {
  static String? username = "jdoe";
  static String? password = "jdoe";
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
