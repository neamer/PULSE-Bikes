import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/fields/text_field.dart';
import 'package:pulse_admin/components/molecules/select/single/servicing_status_single_select.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/model/filters/servicing_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';

class ServicingListFilters extends StatefulWidget {
  const ServicingListFilters({super.key});

  @override
  State<StatefulWidget> createState() {
    return _ServicingListFilterState();
  }
}

class _ServicingListFilterState extends State<ServicingListFilters> {
  final TextEditingController searchController = TextEditingController();
  final ServicingFilter _data = ServicingFilter(
      includeCustomer: true, includeParts: true, includePayment: true);

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
        ServicingStatusSingleSelect(
            width: 170,
            value: _data.status,
            onChanged: (value) => setState(() {
                  _data.status = value;
                })),
        Button(
            text: "Search",
            onClick: () =>
                context.read<ListPageProvider>().searchEvent.publish(_data))
      ],
    );
  }
}
