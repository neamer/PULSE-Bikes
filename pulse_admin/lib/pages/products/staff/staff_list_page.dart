import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/staff_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/staff_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/staff_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/data/user/user.dart';
import 'package:pulse_admin/model/filters/staff_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/staff/staff_provider.dart';

class StaffListPage extends StatelessWidget {
  const StaffListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
          defaultFilters: StaffFilter(
        includeRole: true,
      )),
      child: ListPage<User, StaffProvider>(
        title: "Staff",
        actions: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Button(text: "Add Staff", onClick: () {}),
          )
        ],
        filters: const StaffListFilters(),
        listHeader: const StaffListHeader(),
        itemBuilder: (item) => StaffListItem(item),
      ),
    );
  }
}
