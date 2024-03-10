import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/gear_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/product_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/gear_list_item.dart';
import 'package:pulse_admin/components/templates/list_page/list_page.dart';
import 'package:pulse_admin/data/gear/gear.dart';
import 'package:pulse_admin/model/filters/gear_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/gear_provider.dart';

class GearListPage extends StatelessWidget {
  const GearListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
          defaultFilters: GearFilter(
              includeBrand: true, includeCategory: true, includeSizes: true)),
      child: ListPage<Gear, GearProvider>(
        title: "Browse Gear",
        actions: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Button(text: "Add Gear", onClick: () {}),
          )
        ],
        filters: const GearListFilters(),
        listHeader: const ProductListHeader(),
        itemBuilder: (item) => GearListItem(item),
      ),
    );
  }
}
