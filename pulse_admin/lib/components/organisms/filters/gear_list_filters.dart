import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/fields/text_field.dart';
import 'package:pulse_admin/components/molecules/select/single/brand_single_select.dart';
import 'package:pulse_admin/components/molecules/select/single/gear_category_single_select.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/domain/types/filters/gear_filter.dart';
import 'package:pulse_admin/domain/providers/list_page_provider.dart';

class GearListFilters extends StatefulWidget {
  const GearListFilters({super.key});

  @override
  State<StatefulWidget> createState() {
    return _GearListFilterState();
  }
}

class _GearListFilterState extends State<GearListFilters> {
  final TextEditingController searchController = TextEditingController();
  final GearFilter _data =
      GearFilter(includeBrand: true, includeCategory: true, includeSizes: true);

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
        BrandSingleSelect(
            width: 170,
            value: _data.brand,
            onChanged: (value) => setState(() {
                  _data.brand = value;
                })),
        GearCategorySingleSelect(
            width: 170,
            value: _data.category,
            onChanged: (value) => setState(() {
                  _data.category = value;
                })),
        Button(text: "Search", onClick: fetchWithFilters)
      ],
    );
  }
}
