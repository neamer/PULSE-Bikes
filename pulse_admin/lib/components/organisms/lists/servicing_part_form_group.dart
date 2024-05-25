import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/api/types/part/part.dart';
import 'package:pulse_admin/api/types/servicing/servicing_part.dart';
import 'package:pulse_admin/components/atoms/buttons/ghost_button.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/components/organisms/lists/headers/servicing_part_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/servicing_part_list_item.dart';
import 'package:pulse_admin/components/templates/inline_list.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/pages/products/part/part_select_page.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/dialog_util.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class ServicingPartFormGroup extends StatefulWidget {
  final String name;
  final List<ServicingPart>? initialItems;
  final Function? onChange;
  final bool enabled;

  const ServicingPartFormGroup(
      {super.key,
      this.initialItems,
      required this.name,
      this.onChange,
      this.enabled = true});

  @override
  State<ServicingPartFormGroup> createState() => _ServicingPartFormGroupState();
}

class _ServicingPartFormGroupState extends State<ServicingPartFormGroup> {
  Future deleteItem(BuildContext context,
      FormFieldState<List<ServicingPart>> field, ServicingPart item) async {
    var updatedValue = field.value;
    field.value
        ?.removeWhere((element) => element.product?.id == item.product?.id);

    field.setValue(updatedValue);
    widget.onChange?.call();
  }

  void Function(ServicingPart) editItem(
      FormFieldState<List<ServicingPart>> field) {
    return (ServicingPart item) {
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

  void Function(ServicingPart) _addItem(
      FormFieldState<List<ServicingPart>> field) {
    return (ServicingPart item) {
      if (field.value != null) {
        var updatedValue = [...field.value!];

        updatedValue.add(item);
        field.setValue(updatedValue);
      }
      widget.onChange?.call();
    };
  }

  void Function(Part) addProduct(FormFieldState<List<ServicingPart>> field) {
    return (Part item) => _addItem(
          field,
        )(ServicingPart.fromPart(item));
  }

  void openPartPicker(
      BuildContext context, FormFieldState<List<ServicingPart>> field) {
    openOverlay(
        context,
        PartPickerPage(
          onPick: addProduct(field),
        ));
  }

  @override
  Widget build(BuildContext context) {
    return FormBuilderField(
        name: widget.name,
        initialValue: widget.initialItems ?? [],
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
                          "Parts needed",
                        ),
                        if (widget.enabled)
                          SpacedRow(
                            spacing: Spacing.md,
                            children: [
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
                    InlineList<ServicingPart>(
                        listHeader: const ServicingPartListHeader(),
                        itemBuilder: (item) => ServicingPartListItem(
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
                                            showServicingPartEditDialog(
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
                    const Padding(
                      padding: EdgeInsets.symmetric(vertical: Spacing.xl),
                      child: SizedBox(
                        width: double.infinity,
                        child: SpacedColumn(
                          spacing: Spacing.lg,
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: [
                            Icon(
                              Icons.layers_clear,
                              size: 45,
                              color: ColorTheme.n500,
                            ),
                            Text("No parts added"),
                          ],
                        ),
                      ),
                    )
                ]));
  }
}
