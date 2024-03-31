import 'dart:convert';
import 'dart:io';

import 'package:flutter/material.dart';

class ImageUtil {
  static Image imageFromBase64String(String base64String) {
    return Image.memory(base64Decode(base64String));
  }

  static String base64StringFromFile(File data) {
    return base64Encode(data.readAsBytesSync());
  }
}
