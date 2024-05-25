import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:form_validator/form_validator.dart';
import 'package:pulse_admin/components/molecules/form/named_text_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/picker/customer_picker_form_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/domain/types/forms/servicing_register_form_field_names.dart';

class ServicingRegisterForm extends StatelessWidget {
  final GlobalKey<FormBuilderState> formKey;

  const ServicingRegisterForm({
    super.key,
    required this.formKey,
  });

  @override
  Widget build(BuildContext context) {
    return FormBuilder(
      key: formKey,
      child: SpacedColumn(spacing: Spacing.lg, children: [
        CustomerPickerFormGroup(
          validator: FormBuilderValidators.required(),
          name: ServicingRegisterFormFieldNames.customer,
        ),
        NamedTextFormFieldGroup(
          maxLines: 8,
          name: ServicingRegisterFormFieldNames.request,
          label: "Request",
          validator: ValidationBuilder().minLength(2).build(),
        ),
      ]),
    );
  }
}
