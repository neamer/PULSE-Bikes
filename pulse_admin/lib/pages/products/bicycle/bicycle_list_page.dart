import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/bicycle_provider.dart';
import 'package:pulse_admin/api/types/bicycle/bicycle.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/bicycle_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/bicycle_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/bicycle_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/domain/types/filters/bicycle_filter.dart';
import 'package:pulse_admin/pages/products/bicycle/bicycle_add_page.dart';
import 'package:pulse_admin/pages/products/bicycle/bicycle_details_page.dart';
import 'package:pulse_admin/pages/products/bicycle/bicycle_edit_page.dart';
import 'package:pulse_admin/domain/providers/list_page_provider.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class BicycleListPage extends StatelessWidget {
  const BicycleListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
        defaultFilters: BicycleFilter(
            includeBrand: true, includeCategory: true, includeSizes: true),
      ),
      child: const _BicycleListPage(),
    );
  }
}

class _BicycleListPage extends StatelessWidget {
  const _BicycleListPage();

  void onActionSuccess(BuildContext context) =>
      context.read<ListPageProvider>().fetchEvent.publish(null);

  Future deleteItem(BuildContext context, Bicycle item) async {
    await context.read<BicycleProvider>().delete(item.id!);
    onActionSuccess(context);
  }

  @override
  Widget build(BuildContext context) {
    return ListPage<Bicycle, BicycleProvider>(
      title: "Browse Bicycle",
      actions: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Button(
              text: "Add bicycle",
              onClick: () => openOverlay(
                  context,
                  BicycleAddPage(
                    onSuccess: () => context
                        .read<ListPageProvider>()
                        .fetchEvent
                        .publish(null),
                  ))),
        )
      ],
      filters: const BicycleListFilters(),
      listHeader: const BicycleListHeader(),
      itemBuilder: (item) => BicycleListItem(
        item,
        actions: [
          IconButton(
            icon: const Icon(
              Icons.edit_note_outlined,
              color: ColorTheme.n500,
            ),
            onPressed: () => openOverlay(
                context,
                BicycleEditPage(item,
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
                          "Successfully deleted bicycle ${item.productNumber}"));
            },
          ),
        ],
        onClick: () => openOverlay(
            context,
            BicycleDetailsPage(
              item,
            )),
      ),
    );
  }
}
