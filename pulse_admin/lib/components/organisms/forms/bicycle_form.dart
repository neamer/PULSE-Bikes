import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:form_validator/form_validator.dart';
import 'package:pulse_admin/components/molecules/form/image_field_group.dart';
import 'package:pulse_admin/components/molecules/form/named_numeric_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/named_text_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/select/bicycle_category_single_select_form_group.dart';
import 'package:pulse_admin/components/molecules/form/select/brand_single_select_form_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/components/organisms/lists/available_size_form_group.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/bicycle/bicycle.dart';
import 'package:pulse_admin/model/forms/bicycle_form_field_names.dart';

class BicycleForm extends StatelessWidget {
  final GlobalKey<FormBuilderState> formKey;
  final Bicycle? initialValues;
  final bool enabled;

  const BicycleForm(
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
                name: BicycleFormFieldNames.productNumber,
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
                  name: BicycleFormFieldNames.brand,
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
                name: BicycleFormFieldNames.model,
                label: "Model",
                initialValue: initialValues?.model,
                validator: ValidationBuilder().minLength(2).build(),
              ),
            ),
            Expanded(
              flex: 35,
              child: BicycleCategorySingleSelectFormGroup(
                  enabled: enabled,
                  clearable: enabled,
                  name: BicycleFormFieldNames.category,
                  label: "Category",
                  initialValue: initialValues?.productCategory,
                  validator: FormBuilderValidators.required()),
            ),
          ],
        ),
        NamedTextFormFieldGroup(
          maxLines: 5,
          name: BicycleFormFieldNames.description,
          label: "Description",
          initialValue: initialValues?.description,
          validator: ValidationBuilder().minLength(2).build(),
        ),
        SpacedRow(spacing: Spacing.md, children: [
          Expanded(
              flex: 33,
              child: NamedNumericFormFieldGroup<double>(
                defaultValue: 0.0,
                label: "Weight",
                name: BicycleFormFieldNames.weight,
                initialValue: initialValues?.weight,
                min: 0,
              )),
          Expanded(
              flex: 33,
              child: NamedNumericFormFieldGroup<int>(
                defaultValue: 0,
                label: "Production year",
                name: BicycleFormFieldNames.productionYear,
                initialValue: initialValues?.productionYear,
                min: 0,
              )),
          Expanded(
              flex: 33,
              child: NamedTextFormFieldGroup(
                label: "Wheel size",
                name: BicycleFormFieldNames.wheelSize,
                initialValue: initialValues?.wheelSize,
              )),
        ]),
        SpacedRow(spacing: Spacing.md, children: [
          Expanded(
              flex: 65,
              child: NamedNumericFormFieldGroup<double>(
                defaultValue: 0.0,
                label: "Price",
                name: BicycleFormFieldNames.price,
                initialValue: initialValues?.price,
                min: 0,
              )),
        ]),
        if (initialValues?.id != null)
          ImageFieldGroup(
            enabled: enabled,
            productId: initialValues!.id!,
            initialItems: initialValues?.images ?? [],
          ),
        if (initialValues?.id != null)
          AvailableSizeFormGroup(
            initialItems: initialValues?.availableSizes ?? [],
          )
      ]),
    );
  }
}
