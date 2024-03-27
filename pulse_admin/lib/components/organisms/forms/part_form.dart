import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:form_validator/form_validator.dart';
import 'package:pulse_admin/components/molecules/form/named_numeric_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/named_text_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/select/brand_single_select_form_group.dart';
import 'package:pulse_admin/components/molecules/form/select/part_category_single_select_form_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/part/part.dart';
import 'package:pulse_admin/model/forms/part_form_field_names.dart';

class PartForm extends StatelessWidget {
  final GlobalKey<FormBuilderState> formKey;
  final Part? initialValues;
  final bool enabled;

  const PartForm(
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
        SpacedRow(
          spacing: Spacing.md,
          children: [
            Expanded(
              flex: 65,
              child: NamedTextFormFieldGroup(
                name: PartFormFieldNames.productNumber,
                label: "Product number",
                initialValue: initialValues?.productNumber,
                validator: ValidationBuilder().minLength(2).build(),
              ),
            ),
            Expanded(
              flex: 35,
              child: BrandSingleSelectFormGroup(
                  enabled: enabled,
                  clearable: enabled,
                  name: PartFormFieldNames.brand,
                  label: "Brand",
                  initialValue: initialValues?.brand,
                  validator: FormBuilderValidators.required()),
            ),
          ],
        ),
        SpacedRow(
          spacing: Spacing.md,
          children: [
            Expanded(
              flex: 65,
              child: NamedTextFormFieldGroup(
                name: PartFormFieldNames.model,
                label: "Model",
                initialValue: initialValues?.model,
                validator: ValidationBuilder().minLength(2).build(),
              ),
            ),
            Expanded(
              flex: 35,
              child: PartCategorySingleSelectFormGroup(
                  enabled: enabled,
                  clearable: enabled,
                  name: PartFormFieldNames.category,
                  label: "Category",
                  initialValue: initialValues?.productCategory,
                  validator: FormBuilderValidators.required()),
            ),
          ],
        ),
        NamedTextFormFieldGroup(
          maxLines: 5,
          name: PartFormFieldNames.description,
          label: "Description",
          initialValue: initialValues?.description,
          validator: ValidationBuilder().minLength(2).build(),
        ),
        SpacedRow(spacing: Spacing.md, children: [
          Expanded(
              flex: 65,
              child: NamedNumericFormFieldGroup<double>(
                defaultValue: 0.0,
                label: "Price",
                name: PartFormFieldNames.price,
                initialValue: initialValues?.price,
                min: 0,
              )),
          Expanded(
              flex: 35,
              child: NamedNumericFormFieldGroup<int>(
                defaultValue: 0,
                label: "Available quantity",
                name: PartFormFieldNames.availableQty,
                initialValue: initialValues?.availableQty,
                min: 1,
              )),
        ]),
        const NamedTextFormFieldGroup(
          maxLines: 5,
          name: "TBD",
          label: "Images",
        ),
      ]),
    );
  }
}
