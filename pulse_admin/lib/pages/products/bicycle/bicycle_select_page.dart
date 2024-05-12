import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/organisms/filters/basic_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/bicycle_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/bicycle_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/data/available_size/available_size.dart';
import 'package:pulse_admin/data/bicycle/bicycle.dart';
import 'package:pulse_admin/model/filters/bicycle_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/products/bicycle_provider.dart';
import 'package:pulse_admin/utils/dialog_util.dart';
import 'package:pulse_admin/utils/toast_utils.dart';

class BicyclePickerPage extends StatefulWidget {
  final void Function(Bicycle, AvailableSize) onPick;

  const BicyclePickerPage({super.key, required this.onPick});

  @override
  State<BicyclePickerPage> createState() => _BicyclePickerPageState();
}

class _BicyclePickerPageState extends State<BicyclePickerPage> {
  void itemPicked(Bicycle item, AvailableSize size) {
    widget.onPick(item, size);
    Navigator.pop(context);
  }

  void openPicker(BuildContext context, Bicycle item) {
    if (item.availableSizes != null && item.availableSizes!.isNotEmpty) {
      showAvailableSizeSelectDialog(
          context: context,
          options: item.availableSizes!
              .where((element) =>
                  element.availableQty != null && element.availableQty! > 0)
              .toList(),
          onSuccess: (size) => itemPicked(item, size));
    } else {
      errorToast(context, "Bicycle has no available sizes");
    }
  }

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
        defaultFilters: BicycleFilter(
            includeBrand: true, includeCategory: true, includeSizes: true),
      ),
      child: ListPage<Bicycle, BicycleProvider>(
        title: "Select Bicycle",
        filters: const BasicListFilters(),
        listHeader: const BicycleListHeader(),
        itemBuilder: (item) => BicycleListItem(
          item,
          onClick: () => openPicker(context, item),
        ),
      ),
    );
  }
}
