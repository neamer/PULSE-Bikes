import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/fields/text_field.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/model/filters/basic_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';

class BasicListFilters extends StatefulWidget {
  const BasicListFilters({super.key});

  @override
  State<StatefulWidget> createState() {
    return _BasicListFilterState();
  }
}

class _BasicListFilterState extends State<BasicListFilters> {
  final TextEditingController searchController = TextEditingController();
  final BasicFilter _data = BasicFilter();

  @override
  void initState() {
    super.initState();
    searchController.addListener(() => setState(() {
          _data.anyField = searchController.text;
        }));
    context.read<ListPageProvider>().fetchEvent.subscribe((arg) {
      fetchWithFilters();
    });
  }

  void fetchWithFilters() =>
      context.read<ListPageProvider>().searchEvent.publish(_data);

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
        Button(text: "Search", onClick: fetchWithFilters)
      ],
    );
  }
}
