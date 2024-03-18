import 'package:flutter/material.dart';

void openOverlay(BuildContext context, Widget overlay) {
  Navigator.of(context).push(MaterialPageRoute(
    builder: (context) => overlay,
  ));
}
