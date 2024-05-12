import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_validator/form_validator.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/form/named_numeric_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/named_text_form_field_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/components/organisms/lists/servicing_part_form_group.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/servicing/servicing.dart';
import 'package:pulse_admin/model/forms/servicing_offer_form_fields.dart';

class ServicingOfferForm extends StatefulWidget {
  final GlobalKey<FormBuilderState> formKey;
  final Servicing? initialValues;
  final bool enabled;

  const ServicingOfferForm({
    super.key,
    required this.formKey,
    this.initialValues,
    this.enabled = true,
  });

  @override
  State<ServicingOfferForm> createState() => _ServicingOfferFormState();
}

class _ServicingOfferFormState extends State<ServicingOfferForm> {
  @override
  Widget build(BuildContext context) {
    return FormBuilder(
      key: widget.formKey,
      enabled: widget.enabled,
      child: SpacedColumn(spacing: Spacing.lg, children: [
        const Align(
          alignment: Alignment.topLeft,
          child: Padding(
            padding: EdgeInsets.only(bottom: Spacing.xs),
            child: FieldLabel(
              "Servicing offer",
              size: FieldLabelSize.lg,
              color: Colors.white,
            ),
          ),
        ),
        ServicingPartFormGroup(
          name: ServicingOfferFormFields.servicingParts,
          enabled: widget.enabled,
          initialItems: widget.initialValues?.servicingParts ?? [],
          onChange: () => setState(() {
            widget.formKey.currentState?.save();
          }),
        ),
        SpacedRow(spacing: Spacing.md, children: [
          Expanded(
            flex: 33,
            child: NamedNumericFormFieldGroup<double>(
              enabled: widget.enabled,
              defaultValue: widget.initialValues?.labourCost ?? 0.0,
              label: "Labour cost",
              name: ServicingOfferFormFields.labourCost,
              initialValue: widget.initialValues?.labourCost ?? 0.0,
              min: 0,
            ),
          ),
          const Expanded(flex: 66, child: SizedBox())
        ]),
        NamedTextFormFieldGroup(
          maxLines: 8,
          readOnly: !widget.enabled,
          initialValue: widget.initialValues?.offerDetails,
          name: ServicingOfferFormFields.offerDetails,
          label: "Offer details",
          validator: ValidationBuilder().minLength(2).build(),
        ),
      ]),
    );
  }
}
