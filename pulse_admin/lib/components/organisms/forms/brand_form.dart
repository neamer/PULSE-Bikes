import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_validator/form_validator.dart';
import 'package:pulse_admin/components/molecules/form/named_text_form_field_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/brand/brand.dart';
import 'package:pulse_admin/data/brand/brand_upsert_request.dart';

class BrandForm extends StatelessWidget {
  final GlobalKey<FormBuilderState> formKey;
  final Brand? initialValues;
  final bool enabled;

  const BrandForm(
      {super.key,
      required this.formKey,
      this.initialValues,
      this.enabled = true});

  @override
  Widget build(BuildContext context) {
    return FormBuilder(
      key: formKey,
      enabled: enabled,
      child: SpacedColumn(spacing: Spacing.lg, children: [
        NamedTextFormFieldGroup(
          name: BrandUpsertRequestFieldNames.name,
          label: "Name",
          initialValue: initialValues?.name,
          validator: ValidationBuilder().minLength(2).build(),
        )
      ]),
    );
  }
}
