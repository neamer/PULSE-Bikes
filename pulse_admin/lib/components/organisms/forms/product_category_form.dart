import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_validator/form_validator.dart';
import 'package:pulse_admin/api/types/product_category/product_category.dart';
import 'package:pulse_admin/api/types/product_category/product_category_upsert_request.dart';
import 'package:pulse_admin/components/molecules/form/named_text_form_field_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class ProductCategoryForm extends StatelessWidget {
  final GlobalKey<FormBuilderState> formKey;
  final ProductCategory? initialValues;
  final bool enabled;

  const ProductCategoryForm(
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
          name: ProductCategoryUpsertRequestFieldNames.name,
          label: "Name",
          initialValue: initialValues?.name,
          validator: ValidationBuilder().minLength(2).build(),
        )
      ]),
    );
  }
}
