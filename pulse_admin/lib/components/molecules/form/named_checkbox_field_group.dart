import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/core/style/colors.dart';

class NamedCheckboxFieldGroup extends StatelessWidget {
  final String name;
  final bool enabled;
  final String label;
  final bool? initialValue;
  final String? Function(bool?)? validator;
  final void Function(bool?)? onChanged;

  const NamedCheckboxFieldGroup({
    Key? key,
    this.enabled = true,
    required this.label,
    this.validator,
    required this.name,
    this.initialValue,
    this.onChanged,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return FormBuilderCheckbox(
      title: Text(
        label,
        style: themeData.textTheme.bodyMedium,
      ),
      initialValue: initialValue,
      name: name,
      enabled: enabled,
      validator: validator,
      onChanged: onChanged,
      activeColor: ColorTheme.g400,
      checkColor: Colors.white,
      side: const BorderSide(width: 2, color: ColorTheme.n700),
    );
  }
}
