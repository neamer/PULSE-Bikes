import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/part_provider.dart';
import 'package:pulse_admin/api/types/part/part.dart';
import 'package:pulse_admin/components/organisms/filters/basic_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/product_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/part_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/domain/types/filters/part_filter.dart';
import 'package:pulse_admin/domain/providers/list_page_provider.dart';
import 'package:pulse_admin/domain/types/delegate.dart';

class PartPickerPage extends StatefulWidget {
  final Delegate<Part> onPick;

  const PartPickerPage({super.key, required this.onPick});

  @override
  State<PartPickerPage> createState() => _PartPickerPageState();
}

class _PartPickerPageState extends State<PartPickerPage> {
  void itemPicked(Part item) {
    widget.onPick(item);
    Navigator.pop(context);
  }

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
        defaultFilters: PartFilter(
            includeBrand: true, includeCategory: true, includeSizes: true),
      ),
      child: ListPage<Part, PartProvider>(
        title: "Select Part",
        filters: const BasicListFilters(),
        listHeader: const ProductListHeader(),
        itemBuilder: (item) => PartListItem(
          item,
          onClick: () => itemPicked(item),
        ),
      ),
    );
  }
}
