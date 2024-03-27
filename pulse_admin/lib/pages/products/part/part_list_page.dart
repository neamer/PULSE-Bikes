import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/part_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/product_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/part_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/data/part/part.dart';
import 'package:pulse_admin/model/filters/part_filter.dart';
import 'package:pulse_admin/pages/products/part/part_add_page.dart';
import 'package:pulse_admin/pages/products/part/part_details_page.dart';
import 'package:pulse_admin/pages/products/part/part_edit_page.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/products/part_provider.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class PartListPage extends StatelessWidget {
  const PartListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
        defaultFilters: PartFilter(
            includeBrand: true, includeCategory: true, includeSizes: true),
      ),
      child: const _PartListPage(),
    );
  }
}

class _PartListPage extends StatelessWidget {
  const _PartListPage();

  void onActionSuccess(BuildContext context) =>
      context.read<ListPageProvider>().fetchEvent.publish(null);

  Future deleteItem(BuildContext context, Part item) async {
    await context.read<PartProvider>().delete(item.id!);
    onActionSuccess(context);
  }

  @override
  Widget build(BuildContext context) {
    return ListPage<Part, PartProvider>(
      title: "Browse Parts",
      actions: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Button(
              text: "Add part",
              onClick: () => openOverlay(
                  context,
                  PartAddPage(
                    onSuccess: () => context
                        .read<ListPageProvider>()
                        .fetchEvent
                        .publish(null),
                  ))),
        )
      ],
      filters: const PartListFilters(),
      listHeader: const ProductListHeader(),
      itemBuilder: (item) => PartListItem(
        item,
        actions: [
          IconButton(
            icon: const Icon(
              Icons.edit_note_outlined,
              color: ColorTheme.n500,
            ),
            onPressed: () => openOverlay(context,
                PartEditPage(item, onSuccess: () => onActionSuccess(context))),
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
                          "Successfully deleted part ${item.productNumber}"));
            },
          ),
        ],
        onClick: () => openOverlay(
            context,
            PartDetailsPage(
              item,
            )),
      ),
    );
  }
}
