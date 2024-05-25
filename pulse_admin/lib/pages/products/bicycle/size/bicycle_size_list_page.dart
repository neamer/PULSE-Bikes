import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/bicycle_size_provider.dart';
import 'package:pulse_admin/api/types/bicycle_size/bicycle_size.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/basic_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/basic_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/bicycle_size_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/domain/types/filters/basic_filter.dart';
import 'package:pulse_admin/pages/products/bicycle/size/bicycle_size_add_page.dart';
import 'package:pulse_admin/pages/products/bicycle/size/bicycle_size_details_page.dart';
import 'package:pulse_admin/pages/products/bicycle/size/bicycle_size_edit_page.dart';
import 'package:pulse_admin/domain/providers/list_page_provider.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class BicycleSizeListPage extends StatelessWidget {
  const BicycleSizeListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(defaultFilters: BasicFilter()),
      child: const _BicycleSizeListPage(),
    );
  }
}

class _BicycleSizeListPage extends StatelessWidget {
  const _BicycleSizeListPage();

  void onActionSuccess(BuildContext context) =>
      context.read<ListPageProvider>().fetchEvent.publish(null);

  Future deleteItem(BuildContext context, BicycleSize item) async {
    await context.read<BicycleSizeProvider>().delete(item.id!);
    onActionSuccess(context);
  }

  @override
  Widget build(BuildContext context) {
    return ListPage<BicycleSize, BicycleSizeProvider>(
      title: "Bicycle sizes",
      actions: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Button(
              text: "Add size",
              onClick: () => openOverlay(
                  context,
                  BicycleSizeAddPage(
                    onSuccess: () => context
                        .read<ListPageProvider>()
                        .fetchEvent
                        .publish(null),
                  ))),
        )
      ],
      filters: const BasicListFilters(),
      listHeader: const BasicListHeader(),
      itemBuilder: (item) => BicycleSizeListItem(
        item,
        actions: [
          IconButton(
            icon: const Icon(
              Icons.edit_note_outlined,
              color: ColorTheme.n500,
            ),
            onPressed: () => openOverlay(
                context,
                BicycleSizeEditPage(item,
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
                          "Successfully deleted brand ${item.size}"));
            },
          ),
        ],
        onClick: () => openOverlay(
            context,
            BicycleSizeDetailsPage(item,
                onSuccess: () => onActionSuccess(context))),
      ),
    );
  }
}
