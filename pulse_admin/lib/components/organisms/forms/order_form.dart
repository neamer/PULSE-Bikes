import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:form_validator/form_validator.dart';
import 'package:pulse_admin/api/types/orders/order_detail.dart';
import 'package:pulse_admin/api/types/orders/order_header.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/form/named_checkbox_field_group.dart';
import 'package:pulse_admin/components/molecules/form/named_numeric_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/named_text_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/picker/customer_picker_form_group.dart';
import 'package:pulse_admin/components/molecules/form/static_text_field_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/components/organisms/lists/order_detail_form_group.dart';
import 'package:pulse_admin/components/organisms/order_tracker.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/domain/types/forms/order_form_field_names.dart';

class OrderForm extends StatefulWidget {
  final bool showOrderNumber;
  final GlobalKey<FormBuilderState> formKey;
  final OrderHeader? initialValues;
  final bool enabled;

  const OrderForm(
      {super.key,
      required this.formKey,
      this.initialValues,
      this.enabled = true,
      this.showOrderNumber = true});

  @override
  State<OrderForm> createState() => _OrderFormState();
}

class _OrderFormState extends State<OrderForm> {
  List<OrderDetail> getDetails() =>
      widget.formKey.currentState?.value[OrderFormFieldNames.orderDetails] ??
      (widget.initialValues?.orderDetails ?? []);

  @override
  Widget build(BuildContext context) {
    bool deliveryChecked =
        widget.formKey.currentState?.value[OrderFormFieldNames.delivery] ??
            false;

    double subtotal = getDetails()
        .map((detail) => detail.quantity! * detail.unitPrice!)
        .fold(0, (a, b) => a + b);
    double shippingCost =
        widget.formKey.currentState?.value[OrderFormFieldNames.shippingCost] ??
            (widget.initialValues?.shippingConst ?? 0);
    double total = subtotal + shippingCost;

    return FormBuilder(
      key: widget.formKey,
      enabled: widget.enabled,
      child: SpacedColumn(spacing: Spacing.lg, children: [
        if (widget.initialValues?.staff != null)
          StaticTextFormFieldGroup(
              label: "Created by",
              value:
                  "${widget.initialValues?.staff?.firstName ?? ""} ${widget.initialValues?.staff?.lastName ?? ""}"),
        SpacedRow(
          spacing: Spacing.md,
          children: [
            if (widget.showOrderNumber)
              Expanded(
                flex: 66,
                child: StaticTextFormFieldGroup(
                    label: "Order number",
                    hint: widget.initialValues?.orderNumber == null
                        ? "Will be generated after the order is processed"
                        : "",
                    value: widget.initialValues?.orderNumber ?? ""),
              ),
            Expanded(
              flex: 33,
              child: CustomerPickerFormGroup(
                validator: FormBuilderValidators.required(),
                initialValue: widget.initialValues?.customer,
                enabled: widget.enabled,
                name: OrderFormFieldNames.customer,
              ),
            )
          ],
        ),
        Padding(
            padding: const EdgeInsets.symmetric(vertical: Spacing.lg),
            child: OrderDetailFormGroup(
              name: OrderFormFieldNames.orderDetails,
              initialItems: widget.initialValues?.orderDetails,
              onChange: () => setState(() {
                widget.formKey.currentState?.save();
              }),
              enabled: widget.enabled,
            )),
        if (!widget.enabled && widget.initialValues?.delivery == true)
          const Align(
            alignment: Alignment.topLeft,
            child: Padding(
              padding: EdgeInsets.only(bottom: Spacing.xs),
              child: FieldLabel(
                "Delivery",
                size: FieldLabelSize.lg,
                color: Colors.white,
              ),
            ),
          ),
        if (widget.enabled)
          NamedCheckboxFieldGroup(
            name: OrderFormFieldNames.delivery,
            initialValue: widget.initialValues?.delivery ?? false,
            label: "Delivery",
            onChanged: (val) => setState(() {
              widget.formKey.currentState?.save();
            }),
          ),
        if (!widget.enabled && widget.initialValues?.delivery == true ||
            widget.enabled && deliveryChecked)
          SpacedColumn(spacing: Spacing.lg, children: [
            SpacedRow(
              spacing: Spacing.md,
              children: [
                Expanded(
                  flex: 50,
                  child: NamedTextFormFieldGroup(
                    name: OrderFormFieldNames.country,
                    enabled: widget.enabled && deliveryChecked,
                    label: "Country",
                    initialValue: widget.initialValues?.shippingInfo?.country,
                    validator: deliveryChecked
                        ? ValidationBuilder().minLength(2).build()
                        : null,
                  ),
                ),
                Expanded(
                  flex: 50,
                  child: NamedTextFormFieldGroup(
                    enabled: widget.enabled && deliveryChecked,
                    name: OrderFormFieldNames.state,
                    label: "State or province",
                    initialValue:
                        widget.initialValues?.shippingInfo?.stateOrProvince,
                    validator: deliveryChecked
                        ? ValidationBuilder().minLength(2).build()
                        : null,
                  ),
                ),
              ],
            ),
            SpacedRow(
              spacing: Spacing.md,
              children: [
                Expanded(
                  flex: 33,
                  child: NamedTextFormFieldGroup(
                    name: OrderFormFieldNames.city,
                    enabled: widget.enabled && deliveryChecked,
                    label: "City",
                    initialValue: widget.initialValues?.shippingInfo?.city,
                    validator: deliveryChecked
                        ? ValidationBuilder().minLength(2).build()
                        : null,
                  ),
                ),
                Expanded(
                  flex: 33,
                  child: NamedTextFormFieldGroup(
                    enabled: widget.enabled && deliveryChecked,
                    name: OrderFormFieldNames.zipCode,
                    label: "Zip code",
                    initialValue: widget.initialValues?.shippingInfo?.zipCode,
                    validator: deliveryChecked
                        ? ValidationBuilder().minLength(2).build()
                        : null,
                  ),
                ),
                Expanded(
                  flex: 33,
                  child: NamedTextFormFieldGroup(
                    enabled: widget.enabled && deliveryChecked,
                    name: OrderFormFieldNames.address,
                    label: "Address",
                    initialValue:
                        widget.initialValues?.shippingInfo?.streetAddress,
                    validator: deliveryChecked
                        ? ValidationBuilder().minLength(2).build()
                        : null,
                  ),
                ),
              ],
            ),
            NamedNumericFormFieldGroup<double>(
                enabled: widget.enabled && deliveryChecked,
                label: "Shipping cost",
                name: OrderFormFieldNames.shippingCost,
                onChange: () => setState(() {
                      widget.formKey.currentState?.save();
                    }),
                defaultValue: widget.initialValues?.shippingConst ?? 0),
          ]),
        if (widget.initialValues != null)
          Padding(
            padding: const EdgeInsets.only(top: Spacing.xs),
            child: OrderTracker(widget.initialValues!),
          ),
        if (subtotal != 0 || shippingCost != 0)
          SpacedColumn(spacing: Spacing.lg, children: [
            const Padding(
              padding: EdgeInsets.only(top: Spacing.xl + Spacing.lg),
              child: FieldLabel(
                "Costs",
                size: FieldLabelSize.lg,
                color: Colors.white,
              ),
            ),
            Padding(
              padding: const EdgeInsets.only(top: Spacing.sm),
              child: Center(
                child: SizedBox(
                  width: 350,
                  child: SpacedColumn(spacing: Spacing.md, children: [
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        const Text("Subtotal"),
                        Text(subtotal.toStringAsFixed(2))
                      ],
                    ),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        const Text("Shipping cost"),
                        Text(shippingCost.toStringAsFixed(2))
                      ],
                    ),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        const Text("Total"),
                        Text(total.toStringAsFixed(2))
                      ],
                    ),
                  ]),
                ),
              ),
            ),
          ])
      ]),
    );
  }
}
