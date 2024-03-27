import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/basic_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/basic_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/product_category_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/data/product_category/product_category.dart';
import 'package:pulse_admin/model/filters/basic_filter.dart';
import 'package:pulse_admin/pages/products/part/category/part_category_add_page.dart';
import 'package:pulse_admin/pages/products/part/category/part_category_details_page.dart';
import 'package:pulse_admin/pages/products/part/category/part_category_edit_page.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/products/part_category_provider.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class PartCategoryListPage extends StatelessWidget {
  const PartCategoryListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(defaultFilters: BasicFilter()),
      child: const _PartCategoryListPage(),
    );
  }
}

class _PartCategoryListPage extends StatelessWidget {
  const _PartCategoryListPage();

  void onActionSuccess(BuildContext context) =>
      context.read<ListPageProvider>().fetchEvent.publish(null);

  Future deleteItem(BuildContext context, ProductCategory item) async {
    await context.read<PartCategoryProvider>().delete(item.id!);
    onActionSuccess(context);
  }

  @override
  Widget build(BuildContext context) {
    return ListPage<ProductCategory, PartCategoryProvider>(
      title: "Part categories",
      actions: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Button(
              text: "Add part category",
              onClick: () => openOverlay(
                  context,
                  PartCategoryAddPage(
                    onSuccess: () => context
                        .read<ListPageProvider>()
                        .fetchEvent
                        .publish(null),
                  ))),
        )
      ],
      filters: const BasicListFilters(),
      listHeader: const BasicListHeader(),
      itemBuilder: (item) => ProductCategoryListItem(
        item,
        actions: [
          IconButton(
            icon: const Icon(
              Icons.edit_note_outlined,
              color: ColorTheme.n500,
            ),
            onPressed: () => openOverlay(
                context,
                PartCategoryEditPage(item,
                    onSuccess: () => onActionSuccess(context))),
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
                          "Successfully deleted part category ${item.name}"));
            },
          ),
        ],
        onClick: () => openOverlay(
            context,
            PartCategoryDetailsPage(item,
                onSuccess: () => onActionSuccess(context))),
      ),
    );
  }
}
