import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/basic_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/bicycle_size_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/bicycle_size_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/data/bicycle_size/bicycle_size.dart';
import 'package:pulse_admin/model/filters/basic_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/products/bicycle_size_provider.dart';

class BicycleSizeListPage extends StatelessWidget {
  const BicycleSizeListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(defaultFilters: BasicFilter()),
      child: ListPage<BicycleSize, BicycleSizeProvider>(
        title: "Bicycle Sizes",
        actions: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Button(text: "Add Bicycle Size", onClick: () {}),
          )
        ],
        filters: const BasicListFilters(),
        listHeader: const BicycleSizeListHeader(),
        itemBuilder: (item) => BicycleSizeListItem(item),
      ),
    );
  }
}
