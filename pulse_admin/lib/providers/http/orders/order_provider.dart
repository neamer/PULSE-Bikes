import 'dart:convert';

import 'package:pulse_admin/core/auth/authorization.dart';
import 'package:pulse_admin/data/orders/order_header.dart';
import 'package:pulse_admin/data/payment/payment_insert_request.dart';
import 'package:pulse_admin/providers/http/base/base_crud_provider.dart';
import 'package:pulse_admin/providers/http/base/base_provider.dart';
import 'package:pulse_admin/utils/http_utils.dart';

class OrderProvider extends BaseCRUDProvider<OrderHeader> {
  OrderProvider() : super('Order');

  @override
  OrderHeader fromJson(data) {
    return OrderHeader.fromJson(data);
  }

  Future<OrderHeader?> process(int id, PaymentInsertRequest request) async {
    var url = "${BaseProvider.baseUrl}$endpoint/Process/$id";
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

  Future pack(int id) async {
    var url = "${BaseProvider.baseUrl}$endpoint/Pack/$id";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response = await http!.post(uri, headers: headers);

    if (!isValidResponseCode(response)) {
      throw Exception("Error while packing order $id");
    }
  }

  Future ship(int id) async {
    var url = "${BaseProvider.baseUrl}$endpoint/Ship/$id";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response = await http!.post(uri, headers: headers);

    if (!isValidResponseCode(response)) {
      throw Exception("Error while shipping order $id");
    }
  }

  Future deliver(int id) async {
    var url = "${BaseProvider.baseUrl}$endpoint/Deliver/$id";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response = await http!.post(uri, headers: headers);

    if (!isValidResponseCode(response)) {
      throw Exception("Error while delivering order $id");
    }
  }
}
