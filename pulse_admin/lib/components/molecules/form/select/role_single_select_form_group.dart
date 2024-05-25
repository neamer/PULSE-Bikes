import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/api/types/user/role.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/select/single/abstract_single_select.dart';
import 'package:pulse_admin/components/molecules/select/single/role_single_select.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class RoleSingleSelectFormGroup<T extends AbstractSingleSelect>
    extends StatelessWidget {
  final String name;
  final TextEditingController? controller;
  final bool enabled;
  final bool clearable;
  final String label;
  final Role? initialValue;
  final String? Function(Role?)? validator;

  const RoleSingleSelectFormGroup({
    Key? key,
    this.controller,
    this.enabled = true,
    this.clearable = true,
    required this.label,
    this.validator,
    required this.name,
    this.initialValue,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return SpacedColumn(
        crossAxisAlignment: CrossAxisAlignment.start,
        spacing: Spacing.md + 1,
        children: [
          Padding(
            padding: const EdgeInsets.only(left: Spacing.xs),
            child: FieldLabel(label),
          ),
          FormBuilderField<Role>(
            name: name,
            initialValue: initialValue,
            validator: validator,
            builder: (FormFieldState<Role> field) {
              return InputDecorator(
                decoration: InputDecoration(
                  contentPadding: const EdgeInsets.symmetric(
                    vertical: 0,
                    horizontal: 0,
                  ),
                  isDense: true,
                  errorText: field.errorText,
                  hintText: "Select option",
                  hintStyle: themeData.textTheme.bodyMedium!.copyWith(
                    color: ColorTheme.n500,
                  ),
                ),
                child: RoleSingleSelect(
                  text: "",
                  clearable: clearable,
                  enabled: enabled,
                  value: field.value,
                  width: double.infinity,
                  onChanged: (item) => {field.didChange(item)},
                ),
              );
            },
          ),
        ]);
  }
}
