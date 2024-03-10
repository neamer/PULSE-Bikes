import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/text_field.dart';
import 'package:pulse_admin/components/molecules/select/single/bicycle_category_single_select.dart';
import 'package:pulse_admin/components/molecules/select/single/brand_single_select.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/model/filters/bicycle_filter.dart';

class BicycleListFilters extends StatefulWidget {
  const BicycleListFilters({super.key});

  @override
  State<StatefulWidget> createState() {
    return _BicycleListFilterState();
  }
}

class _BicycleListFilterState extends State<BicycleListFilters> {
  final TextEditingController searchController = TextEditingController();
  final BicycleFilter _data = BicycleFilter(
      includeBrand: true, includeCategory: true, includeSizes: true);

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
            name: 'Enter your search criteria',
            clearable: true,
          ),
        ),
        BrandSingleSelect(
            width: 170,
            value: _data.brand,
            onChanged: (value) => setState(() {
                  _data.brand = value;
                })),
        BicycleCategorySingleSelect(
            width: 170,
            value: _data.category,
            onChanged: (value) => setState(() {
                  _data.category = value;
                })),
        Button(
            text: "Search",
            onClick: () =>
                context.read<ListPageProvider>().searchEvent.publish(_data))
      ],
    );
  }
}
