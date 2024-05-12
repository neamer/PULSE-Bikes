import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:pulse_admin/components/molecules/form/named_numeric_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/select/bicycle_size_single_select_form_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/available_size/available_size.dart';
import 'package:pulse_admin/model/forms/available_size_form_field_names.dart';

class AvailableSizeForm extends StatelessWidget {
  final GlobalKey<FormBuilderState> formKey;
  final AvailableSize? initialValues;
  final bool enabled;
  final bool enableBicycleSize;

  const AvailableSizeForm(
      {super.key,
      required this.formKey,
      this.initialValues,
      this.enabled = true,
      this.enableBicycleSize = true});

  @override
  Widget build(BuildContext context) {
    return FormBuilder(
      key: formKey,
      enabled: enabled,
      child: SpacedColumn(
          spacing: Spacing.lg,
          mainAxisSize: MainAxisSize.min,
          children: [
            BicycleSizeSingleSelectFormGroup(
                enabled: enabled && enableBicycleSize,
                clearable: enabled,
                name: AvailableSizeFormFieldNames.bicycleSize,
                label: "Bicycle size",
                initialValue: initialValues?.bicycleSize,
                validator: FormBuilderValidators.required()),
            NamedNumericFormFieldGroup<int>(
              defaultValue: 0,
              name: AvailableSizeFormFieldNames.availableQty,
              label: "Available quantity",
              initialValue: initialValues?.availableQty,
              min: 0,
            ),
          ]),
    );
  }
}
