import 'package:flutter/material.dart';

class BasicTextField extends StatelessWidget {
  final TextEditingController controller;
  final String name;
  final bool enabled;
  final bool obscureText;

  const BasicTextField(
      {super.key,
      required this.name,
      required this.controller,
      required this.enabled,
      this.obscureText = false});

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
        obscureText: obscureText,
        decoration: InputDecoration(
            border: InputBorder.none,
            hintText: name,
            hintStyle: TextStyle(color: Colors.grey[400])),
      ),
    );
  }
}
