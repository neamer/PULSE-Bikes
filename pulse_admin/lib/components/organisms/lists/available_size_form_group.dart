import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/available_size_provider.dart';
import 'package:pulse_admin/api/types/available_size/available_size.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/organisms/lists/headers/available_size_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/available_size_list_item.dart';
import 'package:pulse_admin/components/templates/inline_list.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/dialog_util.dart';

class AvailableSizeFormGroup extends StatefulWidget {
  final int productId;
  final List<AvailableSize> initialItems;

  const AvailableSizeFormGroup(
      {super.key, required this.initialItems, required this.productId});

  @override
  State<AvailableSizeFormGroup> createState() => _AvailableSizeFormGroupState();
}

class _AvailableSizeFormGroupState extends State<AvailableSizeFormGroup> {
  List<AvailableSize> _items = [];

  @override
  void initState() {
    super.initState();
    _items = widget.initialItems;
  }

  Future deleteItem(BuildContext context, AvailableSize item) async {
    await context.read<AvailableSizeProvider>().delete(item.id!);

    setState(() {
      _items.remove(item);
    });
  }

  void editItem(AvailableSize item) {
    setState(() {
      _items[_items.indexWhere((element) => element.id == item.id)]
          .availableQty = item.availableQty!;
    });
  }

  void addItem(AvailableSize item) {
    setState(() {
      _items.add(item);
    });
  }

  @override
  Widget build(BuildContext context) {
    return SpacedColumn(
        crossAxisAlignment: CrossAxisAlignment.start,
        spacing: Spacing.md + 1,
        children: [
          Padding(
            padding: const EdgeInsets.only(left: Spacing.xs),
            child: Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                const FieldLabel(
                  "Available sizes",
                  color: Colors.white,
                  size: FieldLabelSize.lg,
                ),
                Button(
                  onClick: () => showAvailableSizeAddDialog(
                      context: context,
                      onSuccess: addItem,
                      productId: widget.productId),
                  text: "Add",
                )
              ],
            ),
          ),
          InlineList(
              listHeader: const AvailableSizeListHeader(),
              itemBuilder: (item) => AvailableSizeListItem(item,
                  actions: [
                    IconButton(
                      icon: const Icon(
                        Icons.edit_note_outlined,
                        color: ColorTheme.n500,
                      ),
                      onPressed: () => showAvailableSizeEditDialog(
                          context: context,
                          initialValues: item,
                          onSuccess: editItem),
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
                                context, () => deleteItem(context, item),
                                successMessage:
                                    "Successfully deleted available size ${item.bicycleSize}"));
                      },
                    ),
                  ],
                  onClick: null),
              data: widget.initialItems),
        ]);
  }
}
