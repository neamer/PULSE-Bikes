import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class TextFormFieldGroup extends StatelessWidget {
  final TextEditingController? controller;
  final String hint;
  final bool enabled;
  final bool clearable;
  final String label;
  final String? Function(String?)? validator;

  const TextFormFieldGroup({
    Key? key,
    this.hint = '',
    this.controller,
    this.enabled = true,
    this.clearable = false,
    required this.label,
    this.validator,
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
          enabled: enabled,
          controller: controller,
          validator: validator,
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
            suffixIcon: clearable &&
                    controller != null &&
                    controller!.value.text.isNotEmpty
                ? IconButton(
                    icon: const Icon(
                      Icons.clear,
                      color: ColorTheme.n500,
                    ),
                    onPressed: () {
                      controller?.clear();
                    },
                  )
                : null,
          ),
        ),
      ],
    );
  }
}
