import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/components/molecules/form/named_numeric_form_field_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/model/forms/order_detail_form_fields.dart';

class OrderDetailForm extends StatelessWidget {
  final GlobalKey<FormBuilderState> formKey;
  final int initialValue;
  final bool enabled;

  const OrderDetailForm(
      {super.key,
      required this.formKey,
      required this.initialValue,
      this.enabled = true});

  @override
  Widget build(BuildContext context) {
    return FormBuilder(
      key: formKey,
      enabled: enabled,
      child: SpacedColumn(
          spacing: Spacing.lg,
          mainAxisSize: MainAxisSize.min,
          children: [
            NamedNumericFormFieldGroup<int>(
              defaultValue: initialValue,
              name: OrderDetailFormFieldNames.quantity,
              label: "Quantity",
            )
          ]),
    );
  }
}
