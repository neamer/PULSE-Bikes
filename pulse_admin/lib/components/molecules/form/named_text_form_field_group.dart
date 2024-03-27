import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class NamedTextFormFieldGroup extends StatelessWidget {
  final String name;
  final TextEditingController? controller;
  final String hint;
  final bool enabled;
  final bool clearable;
  final String label;
  final String? initialValue;
  final String? Function(String?)? validator;
  final bool obscureText;
  final int maxLines;

  const NamedTextFormFieldGroup(
      {Key? key,
      this.hint = '',
      this.controller,
      this.enabled = true,
      this.clearable = false,
      required this.label,
      this.validator,
      required this.name,
      this.initialValue,
      this.obscureText = false,
      this.maxLines = 1})
      : super(key: key);

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
        FormBuilderTextField(
          maxLines: maxLines,
          obscureText: obscureText,
          initialValue: initialValue,
          name: name,
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
