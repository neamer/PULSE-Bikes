import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/staff_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/staff_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/staff_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/data/user/user.dart';
import 'package:pulse_admin/model/filters/staff_filter.dart';
import 'package:pulse_admin/pages/staff/staff_add_page.dart';
import 'package:pulse_admin/pages/staff/staff_details_page.dart';
import 'package:pulse_admin/pages/staff/staff_edit_page.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/staff/staff_provider.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class StaffListPage extends StatelessWidget {
  const StaffListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) =>
          ListPageProvider(defaultFilters: StaffFilter(includeRole: true)),
      child: const _StaffListPage(),
    );
  }
}

class _StaffListPage extends StatelessWidget {
  const _StaffListPage();

  void onActionSuccess(BuildContext context) =>
      context.read<ListPageProvider>().fetchEvent.publish(null);

  Future deleteItem(BuildContext context, User item) async {
    await context.read<StaffProvider>().delete(item.id!);
    onActionSuccess(context);
  }

  @override
  Widget build(BuildContext context) {
    return ListPage<User, StaffProvider>(
      title: "Staff",
      actions: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Button(
              text: "Add staff",
              onClick: () => openOverlay(
                  context,
                  StaffAddPage(
                    onSuccess: () => context
                        .read<ListPageProvider>()
                        .fetchEvent
                        .publish(null),
                  ))),
        )
      ],
      filters: const StaffListFilters(),
      listHeader: const StaffListHeader(),
      itemBuilder: (item) => StaffListItem(
        item,
        actions: [
          IconButton(
            icon: const Icon(
              Icons.edit_note_outlined,
              color: ColorTheme.n500,
            ),
            onPressed: () => openOverlay(context,
                StaffEditPage(item, onSuccess: () => onActionSuccess(context))),
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
                          "Successfully deleted brand ${item.toString()}"));
            },
          ),
        ],
        onClick: () => openOverlay(
            context,
            StaffDetailsPage(
              item,
            )),
      ),
    );
  }
}
