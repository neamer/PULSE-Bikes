import 'dart:convert';

import 'package:pulse_mobile/model/servicing/servicing.dart';
import 'package:pulse_mobile/providers/abstract/base_provider.dart';

class ServicingProvider extends BaseProvider<Servicing> {
  ServicingProvider() : super("Servicing");

  @override
  fromJson(data) {
    return Servicing.fromJson(data);
  }

  Future<List<Servicing>> fetchServicingHistory() async {
    var url = "${BaseProvider.baseUrl}$endpoint/Customer";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var response = await http!.get(uri, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data.map((x) => fromJson(x)).cast<Servicing>().toList();
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }

  Future<Servicing?> getDetails(int id) async {
    var url = "${BaseProvider.baseUrl}$endpoint/Details/$id";

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
}
