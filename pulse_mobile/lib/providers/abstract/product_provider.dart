import 'dart:convert';

import 'package:pulse_mobile/model/abstract/product.dart';
import 'package:pulse_mobile/model/orders/order_detail.dart';
import 'package:pulse_mobile/providers/abstract/base_crud_provider.dart';
import 'package:pulse_mobile/providers/abstract/base_provider.dart';

abstract class ProductProvider<T extends Product> extends BaseCRUDProvider<T> {
  ProductProvider(String endpoint) : super(endpoint);

  Future<OrderDetail?> addToCart(OrderDetail item) async {
    var url = "${BaseProvider.baseUrl}OrderDetail$endpoint/Cart";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var jsonRequest = jsonEncode(item);

    var response = await http!.post(uri, headers: headers, body: jsonRequest);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return OrderDetail.fromJson(data);
    } else {
      return null;
    }
  }
}
