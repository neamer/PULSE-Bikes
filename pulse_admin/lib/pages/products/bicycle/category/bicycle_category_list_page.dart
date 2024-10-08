import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/bicycle_category_provider.dart';
import 'package:pulse_admin/api/types/product_category/product_category.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/basic_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/basic_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/product_category_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/domain/types/filters/basic_filter.dart';
import 'package:pulse_admin/pages/products/bicycle/category/bicycle_category_add_page.dart';
import 'package:pulse_admin/pages/products/bicycle/category/bicycle_category_details_page.dart';
import 'package:pulse_admin/pages/products/bicycle/category/bicycle_category_edit_page.dart';
import 'package:pulse_admin/domain/providers/list_page_provider.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class BicycleCategoryListPage extends StatelessWidget {
  const BicycleCategoryListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(defaultFilters: BasicFilter()),
      child: const _BicycleCategoryListPage(),
    );
  }
}

class _BicycleCategoryListPage extends StatelessWidget {
  const _BicycleCategoryListPage();

  void onActionSuccess(BuildContext context) =>
      context.read<ListPageProvider>().fetchEvent.publish(null);

  Future deleteItem(BuildContext context, ProductCategory item) async {
    await context.read<BicycleCategoryProvider>().delete(item.id!);
    onActionSuccess(context);
  }

  @override
  Widget build(BuildContext context) {
    return ListPage<ProductCategory, BicycleCategoryProvider>(
      title: "Bicycle categories",
      actions: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Button(
              text: "Add bicycle category",
              onClick: () => openOverlay(
                  context,
                  BicycleCategoryAddPage(
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
                BicycleCategoryEditPage(item,
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
                          "Successfully deleted bicycle category ${item.name}"));
            },
          ),
        ],
        onClick: () => openOverlay(
            context,
            BicycleCategoryDetailsPage(item,
                onSuccess: () => onActionSuccess(context))),
      ),
    );
  }
}
