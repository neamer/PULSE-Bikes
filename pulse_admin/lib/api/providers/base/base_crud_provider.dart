import 'dart:convert';
import 'dart:async';

import 'package:pulse_admin/api/providers/base/base_provider.dart';
import 'package:pulse_admin/core/auth/authorization.dart';
import 'package:pulse_admin/utils/http_utils.dart';

abstract class BaseCRUDProvider<T> extends BaseProvider<T> {
  BaseCRUDProvider(String endpoint) : super(endpoint);

  Future<T?> insert(dynamic request) async {
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

  Future<T?> update(int id, [dynamic request]) async {
    var url = "${BaseProvider.baseUrl}$endpoint/$id";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response =
        await http!.put(uri, headers: headers, body: jsonEncode(request));

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      return null;
    }
  }

  Future<T?> delete(int id) async {
    var url = "${BaseProvider.baseUrl}$endpoint/$id";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response = await http!.delete(uri, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      return null;
    }
  }
}
