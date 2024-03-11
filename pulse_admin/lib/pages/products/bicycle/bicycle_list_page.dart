import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/bicycle_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/bicycle_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/bicycle_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/data/bicycle/bicycle.dart';
import 'package:pulse_admin/model/filters/bicycle_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/products/bicycle_provider.dart';

class BicycleListPage extends StatelessWidget {
  const BicycleListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
          defaultFilters: BicycleFilter(
              includeBrand: true, includeCategory: true, includeSizes: true)),
      child: ListPage<Bicycle, BicycleProvider>(
        title: "Browse bicycles",
        actions: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Button(text: "Add Bicycle", onClick: () {}),
          )
        ],
        filters: const BicycleListFilters(),
        listHeader: const BicycleListHeader(),
        itemBuilder: (item) => BicycleListItem(item),
      ),
    );
  }
}
