import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:form_validator/form_validator.dart';
import 'package:pulse_admin/api/types/servicing/servicing.dart';
import 'package:pulse_admin/api/types/servicing/servicing_status.dart';
import 'package:pulse_admin/components/molecules/form/named_text_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/picker/customer_picker_form_group.dart';
import 'package:pulse_admin/components/molecules/form/static_text_field_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/domain/types/forms/servicing_details_form_field_names.dart';

class ServicingDetailsForm extends StatelessWidget {
  final Servicing initialValues;
  final GlobalKey<FormBuilderState> formKey;
  final bool enabled;

  const ServicingDetailsForm({
    super.key,
    required this.formKey,
    required this.initialValues,
    this.enabled = true,
  });

  @override
  Widget build(BuildContext context) {
    return FormBuilder(
      key: formKey,
      child: SpacedColumn(spacing: Spacing.lg, children: [
        SpacedRow(
          spacing: Spacing.md,
          children: [
            Expanded(
              flex: 33,
              child: StaticTextFormFieldGroup(
                  label: "Servicing number",
                  value: initialValues.servicingNumber ?? ""),
            ),
            Expanded(
              flex: 33,
              child: StaticTextFormFieldGroup(
                  label: "Status",
                  value:
                      ServicingStatus.values[initialValues.status!].getName()),
            ),
            Expanded(
              flex: 33,
              child: CustomerPickerFormGroup(
                enabled: enabled,
                validator: FormBuilderValidators.required(),
                initialValue: initialValues.customer,
                name: ServicingDetailsFormFieldNames.customer,
              ),
            )
          ],
        ),
        NamedTextFormFieldGroup(
          readOnly: !enabled,
          maxLines: 8,
          name: ServicingDetailsFormFieldNames.request,
          initialValue: initialValues.customerRequest,
          label: "Request",
          validator: ValidationBuilder().minLength(2).build(),
        ),
      ]),
    );
  }
}
