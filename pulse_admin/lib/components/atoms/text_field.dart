import 'package:flutter/material.dart';

class TextInput extends StatelessWidget {
  final TextEditingController controller;
  final String name;
  final bool enabled;

  const TextInput(
      {super.key,
      required this.name,
      required this.controller,
      required this.enabled});

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return Container(
      padding: const EdgeInsets.symmetric(vertical: 10),
      decoration: const BoxDecoration(
          border: Border(bottom: BorderSide(color: Colors.grey))),
      child: TextField(
        enabled: enabled,
        controller: controller,
        style: themeData.textTheme.bodyMedium,
        decoration: InputDecoration(
            border: InputBorder.none,
            hintText: name,
            hintStyle: TextStyle(color: Colors.grey[400])),
      ),
    );
  }
}
