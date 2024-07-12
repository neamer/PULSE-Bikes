import 'dart:convert';

import 'package:pulse_mobile/model/abstract/product.dart';
import 'package:pulse_mobile/model/bicycle/bicycle.dart';
import 'package:pulse_mobile/model/gear/gear.dart';
import 'package:pulse_mobile/model/orders/order_detail_request.dart';
import 'package:pulse_mobile/model/part/part.dart';
import 'package:pulse_mobile/providers/abstract/base_crud_provider.dart';
import 'package:pulse_mobile/providers/abstract/base_provider.dart';

abstract class ProductProvider<T extends Product> extends BaseCRUDProvider<T> {
  ProductProvider(String endpoint) : super(endpoint);

  Future<OrderDetailRequest?> addToCart(OrderDetailRequest item) async {
    var url = "${BaseProvider.baseUrl}OrderDetail$endpoint/Cart";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var jsonRequest = jsonEncode(item);

    var response = await http!.post(uri, headers: headers, body: jsonRequest);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return OrderDetailRequest.fromJson(data);
    } else {
      return null;
    }
  }

  Future<List<Product>> getFrequentlyBoughtTogether(int productId) async {
    var url =
        "${BaseProvider.baseUrl}Recommendation/similar-products/$productId";

    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var response = await http!.get(uri, headers: headers);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data
          .map((x) {
            var product = Product.fromJson(x);

            if (product.discriminator == "Bicycle") {
              return Bicycle.fromJson(x);
            } else if (product.discriminator == "Gear") {
              return Gear.fromJson(x);
            } else {
              return Part.fromJson(x);
            }
          })
          .cast<Product>()
          .toList();
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }
}
