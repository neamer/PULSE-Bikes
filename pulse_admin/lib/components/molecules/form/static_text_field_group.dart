import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class StaticTextFormFieldGroup extends StatelessWidget {
  final String hint;
  final String label;
  final String value;

  const StaticTextFormFieldGroup({
    Key? key,
    this.hint = '',
    required this.label,
    required this.value,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return SpacedColumn(
      crossAxisAlignment: CrossAxisAlignment.start,
      spacing: Spacing.md,
      children: [
        Padding(
          padding: const EdgeInsets.only(left: Spacing.xs),
          child: FieldLabel(label),
        ),
        TextFormField(
          readOnly: true,
          controller:
              TextEditingController.fromValue(TextEditingValue(text: value)),
          style: themeData.textTheme.bodyMedium,
          decoration: InputDecoration(
            filled: true,
            contentPadding: const EdgeInsets.symmetric(
              horizontal: Spacing.lg,
              vertical: Spacing.lg,
            ),
            fillColor: ColorTheme.m600,
            isDense: true,
            hintText: hint,
            hintStyle: themeData.textTheme.bodyMedium!.copyWith(
              color: ColorTheme.n500,
            ),
            border: OutlineInputBorder(
              borderSide: BorderSide.none,
              borderRadius: BorderRadius.circular(Radius.xs),
            ),
          ),
        ),
      ],
    );
  }
}
