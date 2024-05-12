import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:form_validator/form_validator.dart';
import 'package:pulse_admin/components/molecules/form/image_field_group.dart';
import 'package:pulse_admin/components/molecules/form/named_numeric_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/named_text_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/select/brand_single_select_form_group.dart';
import 'package:pulse_admin/components/molecules/form/select/gear_category_single_select_form_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/gear/gear.dart';
import 'package:pulse_admin/model/forms/gear_form_field_names.dart';

class GearForm extends StatelessWidget {
  final GlobalKey<FormBuilderState> formKey;
  final Gear? initialValues;
  final bool enabled;

  const GearForm(
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
                name: GearFormFieldNames.productNumber,
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
                  name: GearFormFieldNames.brand,
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
                name: GearFormFieldNames.model,
                label: "Model",
                initialValue: initialValues?.model,
                validator: ValidationBuilder().minLength(2).build(),
              ),
            ),
            Expanded(
              flex: 35,
              child: GearCategorySingleSelectFormGroup(
                  enabled: enabled,
                  clearable: enabled,
                  name: GearFormFieldNames.category,
                  label: "Category",
                  initialValue: initialValues?.productCategory,
                  validator: FormBuilderValidators.required()),
            ),
          ],
        ),
        NamedTextFormFieldGroup(
          maxLines: 5,
          name: GearFormFieldNames.description,
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
                name: GearFormFieldNames.price,
                initialValue: initialValues?.price,
                min: 0,
              )),
          Expanded(
              flex: 35,
              child: NamedNumericFormFieldGroup<int>(
                defaultValue: 0,
                label: "Available quantity",
                name: GearFormFieldNames.availableQty,
                initialValue: initialValues?.availableQty,
                min: 1,
              )),
        ]),
        if (initialValues?.id != null)
          ImageFieldGroup(
            enabled: enabled,
            productId: initialValues!.id!,
            initialItems: initialValues?.images ?? [],
          )
      ]),
    );
  }
}