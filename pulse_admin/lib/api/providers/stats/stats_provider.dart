import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';
import 'package:pulse_admin/api/types/stats/bicycle_category_stats.dart';
import 'package:pulse_admin/api/types/stats/bicycle_price_stats.dart';
import 'package:pulse_admin/api/types/stats/stats.dart';
import 'package:pulse_admin/core/auth/authorization.dart';
import 'package:pulse_admin/utils/http_utils.dart';

class StatsProvider with ChangeNotifier {
  static String? baseUrl;

  HttpClient client = HttpClient();
  IOClient? http;

  StatsProvider() {
    baseUrl =
        const String.fromEnvironment("baseUrl", defaultValue: HttpConfig.url);

    if (baseUrl!.endsWith("/") == false) {
      baseUrl = "${baseUrl!}/";
    }

    client.badCertificateCallback = (cert, host, port) => true;
    http = IOClient(client);
  }

  Future<List<Stats>> getRevenueByMonth(int year) async {
    var url = "${baseUrl}stats/revenue-per-month/$year";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response = await http!.get(uri, headers: headers);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data.map((x) => Stats.fromJson(x)).cast<Stats>().toList();
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }

  Future<List<Stats>> getSalesByMonth(int year) async {
    var url = "${baseUrl}stats/sales-per-month/$year";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response = await http!.get(uri, headers: headers);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data.map((x) => Stats.fromJson(x)).cast<Stats>().toList();
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }

  Future<List<BicycleCategoryStats>> getBicycleCategoryStats() async {
    var url = "${baseUrl}stats/bicycle-sales-per-category";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response = await http!.get(uri, headers: headers);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data
          .map((x) => BicycleCategoryStats.fromJson(x))
          .cast<BicycleCategoryStats>()
          .toList();
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }

  Future<List<BicyclePriceStats>> getBicyclePriceStats() async {
    var url = "${baseUrl}stats/bicycle-sales-per-price-range";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response = await http!.get(uri, headers: headers);
    print(response.body);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data
          .map((x) => BicyclePriceStats.fromJson(x))
          .cast<BicyclePriceStats>()
          .toList();
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }
}
