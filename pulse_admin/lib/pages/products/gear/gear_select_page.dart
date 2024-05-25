import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/gear_provider.dart';
import 'package:pulse_admin/api/types/gear/gear.dart';
import 'package:pulse_admin/components/organisms/filters/basic_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/product_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/gear_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/domain/types/filters/gear_filter.dart';
import 'package:pulse_admin/domain/providers/list_page_provider.dart';
import 'package:pulse_admin/domain/types/delegate.dart';

class GearPickerPage extends StatefulWidget {
  final Delegate<Gear> onPick;

  const GearPickerPage({super.key, required this.onPick});

  @override
  State<GearPickerPage> createState() => _GearPickerPageState();
}

class _GearPickerPageState extends State<GearPickerPage> {
  void itemPicked(Gear item) {
    widget.onPick(item);
    Navigator.pop(context);
  }

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
        defaultFilters: GearFilter(
            includeBrand: true, includeCategory: true, includeSizes: true),
      ),
      child: ListPage<Gear, GearProvider>(
        title: "Select Gear",
        filters: const BasicListFilters(),
        listHeader: const ProductListHeader(),
        itemBuilder: (item) => GearListItem(
          item,
          onClick: () => itemPicked(item),
        ),
      ),
    );
  }
}
