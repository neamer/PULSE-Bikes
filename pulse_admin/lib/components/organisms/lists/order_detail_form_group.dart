import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:pulse_admin/api/types/abstract/product.dart';
import 'package:pulse_admin/api/types/available_size/available_size.dart';
import 'package:pulse_admin/api/types/orders/order_detail.dart';
import 'package:pulse_admin/components/atoms/buttons/ghost_button.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/components/organisms/lists/headers/order_detail_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/order_detail_list_item.dart';
import 'package:pulse_admin/components/templates/inline_list.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/pages/products/bicycle/bicycle_select_page.dart';
import 'package:pulse_admin/pages/products/gear/gear_select_page.dart';
import 'package:pulse_admin/pages/products/part/part_select_page.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/dialog_util.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class OrderDetailFormGroup extends StatefulWidget {
  final String name;
  final List<OrderDetail>? initialItems;
  final Function? onChange;
  final bool enabled;

  const OrderDetailFormGroup(
      {super.key,
      this.initialItems,
      required this.name,
      this.onChange,
      this.enabled = true});

  @override
  State<OrderDetailFormGroup> createState() => _OrderDetailFormGroupState();
}

class _OrderDetailFormGroupState extends State<OrderDetailFormGroup> {
  Future deleteItem(BuildContext context,
      FormFieldState<List<OrderDetail>> field, OrderDetail item) async {
    var updatedValue = field.value;
    field.value
        ?.removeWhere((element) => element.product?.id == item.product?.id);

    field.setValue(updatedValue);
    widget.onChange?.call();
  }

  void Function(OrderDetail) editItem(FormFieldState<List<OrderDetail>> field) {
    return (OrderDetail item) {
      var updatedValue = field.value;

      if (updatedValue != null) {
        updatedValue[updatedValue.indexWhere(
                (element) => element.product?.id == item.product?.id)]
            .quantity = item.quantity!;

        field.setValue(updatedValue);
      }
      widget.onChange?.call();
    };
  }

  void Function(OrderDetail) _addItem(FormFieldState<List<OrderDetail>> field) {
    return (OrderDetail item) {
      if (field.value != null) {
        var updatedValue = [...field.value!];

        updatedValue.add(item);
        field.setValue(updatedValue);
      }
      widget.onChange?.call();
    };
  }

  void Function(Product) addProduct(FormFieldState<List<OrderDetail>> field) {
    return (Product item) => _addItem(
          field,
        )(OrderDetail.fromProduct(item, null));
  }

  void Function(Product, AvailableSize) addBicycle(
      FormFieldState<List<OrderDetail>> field) {
    return (Product item, AvailableSize size) => _addItem(
          field,
        )(OrderDetail.fromProduct(item, size));
  }

  void openPartPicker(
      BuildContext context, FormFieldState<List<OrderDetail>> field) {
    openOverlay(
        context,
        PartPickerPage(
          onPick: addProduct(field),
        ));
  }

  void openGearPicker(
      BuildContext context, FormFieldState<List<OrderDetail>> field) {
    openOverlay(
        context,
        GearPickerPage(
          onPick: addProduct(field),
        ));
  }

  void openBicyclePicker(
      BuildContext context, FormFieldState<List<OrderDetail>> field) {
    openOverlay(
        context,
        BicyclePickerPage(
          onPick: addBicycle(field),
        ));
  }

  @override
  Widget build(BuildContext context) {
    return FormBuilderField(
        name: widget.name,
        initialValue: widget.initialItems ?? [],
        validator: FormBuilderValidators.required(),
        builder: (field) => SpacedColumn(
                crossAxisAlignment: CrossAxisAlignment.start,
                spacing: Spacing.md + 1,
                children: [
                  Padding(
                    padding: const EdgeInsets.only(left: Spacing.xs),
                    child: Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        const FieldLabel(
                          "Products",
                          color: Colors.white,
                          size: FieldLabelSize.lg,
                        ),
                        if (widget.enabled)
                          SpacedRow(
                            spacing: Spacing.md,
                            children: [
                              GhostButton(
                                onClick: () =>
                                    openBicyclePicker(context, field),
                                text: "Add Bicycle",
                              ),
                              GhostButton(
                                onClick: () => openGearPicker(context, field),
                                text: "Add Gear",
                              ),
                              GhostButton(
                                onClick: () => openPartPicker(context, field),
                                text: "Add Part",
                              ),
                            ],
                          )
                      ],
                    ),
                  ),
                  if (field.value != null && field.value!.isNotEmpty)
                    InlineList<OrderDetail>(
                        listHeader: const OrderDetailListHeader(),
                        itemBuilder: (item) => OrderDetailListItem(
                              item,
                              onClick: () {},
                              actions: widget.enabled
                                  ? [
                                      IconButton(
                                        icon: const Icon(
                                          Icons.edit_note_outlined,
                                          color: ColorTheme.n500,
                                        ),
                                        onPressed: () =>
                                            showOrderDetailEditDialog(
                                          context: context,
                                          initialValues: item,
                                          onSuccess: editItem(field),
                                        ),
                                      ),
                                      IconButton(
                                        icon: const Icon(
                                          Icons.delete_outline,
                                          color: ColorTheme.r400,
                                        ),
                                        onPressed: () {
                                          showDeleteConfirmationDialog(
                                              context,
                                              genericRequestHandler(
                                                  context,
                                                  () => deleteItem(
                                                      context, field, item),
                                                  successMessage:
                                                      "Successfully removed ${item.product}"));
                                        },
                                      ),
                                    ]
                                  : null,
                            ),
                        data: field.value!),
                  if (field.value == null || field.value!.isEmpty)
                    Padding(
                      padding: const EdgeInsets.symmetric(vertical: 100),
                      child: SizedBox(
                        width: double.infinity,
                        child: SpacedColumn(
                          spacing: Spacing.lg,
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: [
                            const Icon(
                              Icons.layers_clear,
                              size: 45,
                              color: ColorTheme.n500,
                            ),
                            const Text("No products added"),
                            Text(
                              "You must add at least one product to submit the order",
                              style: Theme.of(context)
                                  .textTheme
                                  .bodyMedium
                                  ?.copyWith(color: ColorTheme.n500),
                            ),
                          ],
                        ),
                      ),
                    )
                ]));
  }
}
