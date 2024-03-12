import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/part_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/product_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/part_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/data/part/part.dart';
import 'package:pulse_admin/model/filters/part_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/products/part_provider.dart';

class PartListPage extends StatelessWidget {
  const PartListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
          defaultFilters: PartFilter(
              includeBrand: true, includeCategory: true, includeSizes: true)),
      child: ListPage<Part, PartProvider>(
        title: "Browse Parts",
        actions: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Button(text: "Add Part", onClick: () {}),
          )
        ],
        filters: const PartListFilters(),
        listHeader: const ProductListHeader(),
        itemBuilder: (item) => PartListItem(item),
      ),
    );
  }
}
