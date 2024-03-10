import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/product_category_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/product_category_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/product_category_list_item.dart';
import 'package:pulse_admin/components/templates/list_page/list_page.dart';
import 'package:pulse_admin/data/product_category/product_category.dart';
import 'package:pulse_admin/model/filters/product_category_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/bicycle_category_provider.dart';

class BicycleCategoryListPage extends StatelessWidget {
  const BicycleCategoryListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) =>
          ListPageProvider(defaultFilters: ProductCategoryFilter()),
      child: ListPage<ProductCategory, BicycleCategoryProvider>(
        title: "Bicycle Categories",
        actions: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Button(text: "Add Bicycle Category", onClick: () {}),
          )
        ],
        filters: const ProductCategoryListFilters(),
        listHeader: const ProductCategoryListHeader(),
        itemBuilder: (item) => ProductCategoryListItem(item),
      ),
    );
  }
}
