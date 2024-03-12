import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/fields/text_field.dart';
import 'package:pulse_admin/components/molecules/select/single/role_single_select.dart';
import 'package:pulse_admin/components/molecules/select/single/status_single_select.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/model/filters/staff_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';

class StaffListFilters extends StatefulWidget {
  const StaffListFilters({super.key});

  @override
  State<StatefulWidget> createState() {
    return _StaffListFilterState();
  }
}

class _StaffListFilterState extends State<StaffListFilters> {
  final TextEditingController searchController = TextEditingController();
  final StaffFilter _data = StaffFilter(includeRole: true);

  @override
  void initState() {
    super.initState();
    searchController.addListener(() => setState(() {
          _data.anyField = searchController.text;
        }));
  }

  @override
  Widget build(BuildContext context) {
    return SpacedRow(
      spacing: Spacing.md,
      children: [
        Expanded(
          child: TextInput(
            controller: searchController,
            hint: 'Enter your search criteria',
            clearable: true,
          ),
        ),
        StatusSingleSelect(
            width: 170,
            value: _data.status,
            onChanged: (value) => setState(() {
                  _data.status = value;
                })),
        RoleSingleSelect(
            width: 170,
            value: _data.role,
            onChanged: (value) => setState(() {
                  _data.role = value;
                })),
        Button(
            text: "Search",
            onClick: () =>
                context.read<ListPageProvider>().searchEvent.publish(_data))
      ],
    );
  }
}
