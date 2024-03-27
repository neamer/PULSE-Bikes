import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/basic_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/basic_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/brand_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/data/brand/brand.dart';
import 'package:pulse_admin/model/filters/basic_filter.dart';
import 'package:pulse_admin/pages/brand/brand_add_page.dart';
import 'package:pulse_admin/pages/brand/brand_details_page.dart';
import 'package:pulse_admin/pages/brand/brand_edit_page.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/products/brand_provider.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class BrandListPage extends StatelessWidget {
  const BrandListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(defaultFilters: BasicFilter()),
      child: const _BrandListPage(),
    );
  }
}

class _BrandListPage extends StatelessWidget {
  const _BrandListPage();

  void onActionSuccess(BuildContext context) =>
      context.read<ListPageProvider>().fetchEvent.publish(null);

  Future deleteItem(BuildContext context, Brand item) async {
    await context.read<BrandProvider>().delete(item.id!);
    onActionSuccess(context);
  }

  @override
  Widget build(BuildContext context) {
    return ListPage<Brand, BrandProvider>(
      title: "Brands",
      actions: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Button(
              text: "Add Brand",
              onClick: () => openOverlay(
                  context,
                  BrandAddPage(
                    onSuccess: () => context
                        .read<ListPageProvider>()
                        .fetchEvent
                        .publish(null),
                  ))),
        )
      ],
      filters: const BasicListFilters(),
      listHeader: const BasicListHeader(),
      itemBuilder: (item) => BrandListItem(
        item,
        actions: [
          IconButton(
            icon: const Icon(
              Icons.edit_note_outlined,
              color: ColorTheme.n500,
            ),
            onPressed: () => openOverlay(context,
                BrandEditPage(item, onSuccess: () => onActionSuccess(context))),
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
                          "Successfully deleted brand ${item.name}"));
            },
          ),
        ],
        onClick: () => openOverlay(
            context,
            BrandDetailsPage(
              item,
            )),
      ),
    );
  }
}
