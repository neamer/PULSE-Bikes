import 'package:flutter/material.dart';

class Messages {
  static void errorMessage(BuildContext context, String message) => showDialog(
      context: context,
      builder: (BuildContext context) => AlertDialog(
            title: const Text("Error"),
            content: Text(message),
            actions: [
              TextButton(
                child: const Text("Ok"),
                onPressed: () => Navigator.pop(context),
              )
            ],
          ));
}
