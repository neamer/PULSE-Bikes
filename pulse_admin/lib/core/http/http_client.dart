import 'dart:io';

import 'package:http/io_client.dart';

abstract class AbstractHttpClient {
  HttpClient client = HttpClient();
  IOClient? http;

  AbstractHttpClient() {
    client.badCertificateCallback = (cert, host, port) => true;
    http = IOClient(client);
  }
}
