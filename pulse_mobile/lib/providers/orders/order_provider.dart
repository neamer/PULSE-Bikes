import 'dart:convert';

import 'package:pulse_mobile/model/orders/order_detail.dart';
import 'package:pulse_mobile/model/orders/order_header.dart';
import 'package:pulse_mobile/providers/abstract/base_provider.dart';

class OrderProvider extends BaseProvider {
  OrderProvider() : super("Order");

  @override
  fromJson(data) {
    return OrderHeader.fromJson(data);
  }

  Future<OrderHeader?> fetchCart() async {
    var url = "${BaseProvider.baseUrl}$endpoint/Cart";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var response = await http!.get(uri, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      return null;
    }
  }


  Future<OrderDetail?> removeCartItem(int id) async {
    var url = "${BaseProvider.baseUrl}$endpoint/Cart/$id";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var response = await http!.delete(uri, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return OrderDetail.fromJson(data);
    } else {
      return null;
    }
  }
}
