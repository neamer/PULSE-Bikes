import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class StaticTextInput extends StatelessWidget {
  final String value;
  final String hint;

  const StaticTextInput({
    super.key,
    required this.hint,
    required this.value,
  });

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return TextField(
      style: themeData.textTheme.bodyMedium,
      controller:
          TextEditingController.fromValue(TextEditingValue(text: value)),
      decoration: InputDecoration(
        filled: true,
        contentPadding: const EdgeInsets.symmetric(
            horizontal: Spacing.lg, vertical: Spacing.lg),
        fillColor: ColorTheme.m600,
        isDense: true,
        hintText: hint,
        hintStyle:
            themeData.textTheme.bodyMedium!.copyWith(color: ColorTheme.n500),
        border: OutlineInputBorder(
            borderSide: BorderSide.none,
            borderRadius: BorderRadius.circular(Radius.xs)),
      ),
    );
  }
}
