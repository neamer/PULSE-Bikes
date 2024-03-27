import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/gear_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/product_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/gear_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/data/gear/gear.dart';
import 'package:pulse_admin/model/filters/gear_filter.dart';
import 'package:pulse_admin/pages/products/gear/gear_add_page.dart';
import 'package:pulse_admin/pages/products/gear/gear_details_page.dart';
import 'package:pulse_admin/pages/products/gear/gear_edit_page.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/products/gear_provider.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class GearListPage extends StatelessWidget {
  const GearListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
        defaultFilters: GearFilter(
            includeBrand: true, includeCategory: true, includeSizes: true),
      ),
      child: const _GearListPage(),
    );
  }
}

class _GearListPage extends StatelessWidget {
  const _GearListPage();

  void onActionSuccess(BuildContext context) =>
      context.read<ListPageProvider>().fetchEvent.publish(null);

  Future deleteItem(BuildContext context, Gear item) async {
    await context.read<GearProvider>().delete(item.id!);
    onActionSuccess(context);
  }

  @override
  Widget build(BuildContext context) {
    return ListPage<Gear, GearProvider>(
      title: "Browse Gear",
      actions: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Button(
              text: "Add gear",
              onClick: () => openOverlay(
                  context,
                  GearAddPage(
                    onSuccess: () => context
                        .read<ListPageProvider>()
                        .fetchEvent
                        .publish(null),
                  ))),
        )
      ],
      filters: const GearListFilters(),
      listHeader: const ProductListHeader(),
      itemBuilder: (item) => GearListItem(
        item,
        actions: [
          IconButton(
            icon: const Icon(
              Icons.edit_note_outlined,
              color: ColorTheme.n500,
            ),
            onPressed: () => openOverlay(context,
                GearEditPage(item, onSuccess: () => onActionSuccess(context))),
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
                          "Successfully deleted gear ${item.productNumber}"));
            },
          ),
        ],
        onClick: () => openOverlay(
            context,
            GearDetailsPage(
              item,
            )),
      ),
    );
  }
}
