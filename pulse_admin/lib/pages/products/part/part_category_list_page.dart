import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/basic_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/basic_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/product_category_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/data/product_category/product_category.dart';
import 'package:pulse_admin/model/filters/basic_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/products/part_category_provider.dart';

class PartCategoryListPage extends StatelessWidget {
  const PartCategoryListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(defaultFilters: BasicFilter()),
      child: ListPage<ProductCategory, PartCategoryProvider>(
        title: "Part Categories",
        actions: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Button(text: "Add Part Category", onClick: () {}),
          )
        ],
        filters: const BasicListFilters(),
        listHeader: const BasicListHeader(),
        itemBuilder: (item) => ProductCategoryListItem(item),
      ),
    );
  }
}
