import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:pulse_admin/api/types/available_size/available_size.dart';
import 'package:pulse_admin/components/molecules/form/select/available_size_static_single_select_form_group.dart';
import 'package:pulse_admin/domain/types/forms/bicycle_size_select_form_field_names.dart';

class AvailableSizeSelectForm extends StatelessWidget {
  final GlobalKey<FormBuilderState> formKey;
  final List<AvailableSize> items;

  const AvailableSizeSelectForm({
    super.key,
    required this.formKey,
    required this.items,
  });

  @override
  Widget build(BuildContext context) {
    return FormBuilder(
      key: formKey,
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          AvailableSizeSingleSelectStaticFormGroup(
              items: items,
              name: AvailableSizeSelectFormFieldNames.bicycleSize,
              label: "Size",
              validator: FormBuilderValidators.required()),
        ],
      ),
    );
  }
}
