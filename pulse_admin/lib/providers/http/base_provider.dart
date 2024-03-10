import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';
import 'package:pulse_admin/core/auth/authorization.dart';
import 'package:pulse_admin/utils/http_utils.dart';

abstract class BaseProvider<T> with ChangeNotifier {
  static String? baseUrl;
  String? endpoint;

  HttpClient client = HttpClient();
  IOClient? http;

  BaseProvider(String endpointParam) {
    baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://localhost:5000");

    if (baseUrl!.endsWith("/") == false) {
      baseUrl = "${baseUrl!}/";
    }

    endpoint = endpointParam;
    client.badCertificateCallback = (cert, host, port) => true;
    http = IOClient(client);
  }

  Future<T?> getById(int id, [dynamic search]) async {
    var url = "$baseUrl$endpoint/$id";

    if (search != null) {
      String queryString = getQueryString(search);
      url = "$url?$queryString";
    }

    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response = await http!.get(uri, headers: headers);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }

  Future<List<T>> get([dynamic search]) async {
    var url = "$baseUrl$endpoint";

    if (search != null) {
      String queryString = getQueryString(search);
      url = "$url?$queryString";
    }

    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var response = await http!.get(uri, headers: headers);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data.map((x) => fromJson(x)).cast<T>().toList();
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }

  T fromJson(data) {
    throw Exception("Override method");
  }
}
