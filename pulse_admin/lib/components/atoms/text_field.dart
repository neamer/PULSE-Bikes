import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class TextInput extends StatelessWidget {
  final TextEditingController controller;
  final String name;
  final bool enabled;
  final bool clearable;

  const TextInput(
      {super.key,
      required this.name,
      required this.controller,
      this.enabled = true,
      this.clearable = false});

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return TextField(
      enabled: enabled,
      controller: controller,
      style: themeData.textTheme.bodyMedium,
      decoration: InputDecoration(
        filled: true,
        contentPadding: const EdgeInsets.symmetric(
            horizontal: Spacing.lg, vertical: Spacing.lg),
        fillColor: ColorTheme.m600,
        isDense: true,
        hintText: name,
        hintStyle:
            themeData.textTheme.bodyMedium!.copyWith(color: ColorTheme.n500),
        border: OutlineInputBorder(
            borderSide: BorderSide.none,
            borderRadius: BorderRadius.circular(Radius.xs)),
        suffixIcon: clearable && controller.value.text != ""
            ? IconButton(
                icon: const Icon(
                  Icons.clear,
                  color: ColorTheme.n500,
                ),
                onPressed: () {
                  controller.clear();
                },
              )
            : null,
      ),
    );
  }
}
