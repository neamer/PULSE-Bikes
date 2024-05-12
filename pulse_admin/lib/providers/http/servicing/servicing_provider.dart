import 'dart:convert';

import 'package:pulse_admin/core/auth/authorization.dart';
import 'package:pulse_admin/data/payment/payment_insert_request.dart';
import 'package:pulse_admin/data/servicing/requests/servicing_offer_insert_request.dart';
import 'package:pulse_admin/data/servicing/servicing.dart';
import 'package:pulse_admin/providers/http/base/base_crud_provider.dart';
import 'package:pulse_admin/providers/http/base/base_provider.dart';
import 'package:pulse_admin/utils/http_utils.dart';

class ServicingProvider extends BaseCRUDProvider<Servicing> {
  ServicingProvider() : super('Servicing');

  @override
  Servicing fromJson(data) {
    return Servicing.fromJson(data);
  }

  Future<Servicing?> submitOffer(
      int id, ServicingOfferInsertRequest request) async {
    var url = "${BaseProvider.baseUrl}$endpoint/$id/Offer";
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

  Future<Servicing?> registerPayment(
      int id, PaymentInsertRequest request) async {
    var url = "${BaseProvider.baseUrl}$endpoint/$id/RegisterPayment";
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

  Future complete(int id) async {
    var url = "${BaseProvider.baseUrl}$endpoint/$id/Complete";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response = await http!.post(uri, headers: headers);

    if (!isValidResponseCode(response)) {
      throw Exception("Error while completing servicing $id");
    }
  }
}
