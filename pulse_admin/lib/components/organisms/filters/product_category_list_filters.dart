import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/text_field.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/model/filters/product_category_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';

class ProductCategoryListFilters extends StatefulWidget {
  const ProductCategoryListFilters({super.key});

  @override
  State<StatefulWidget> createState() {
    return _ProductCategoryListFilterState();
  }
}

class _ProductCategoryListFilterState
    extends State<ProductCategoryListFilters> {
  final TextEditingController searchController = TextEditingController();
  final ProductCategoryFilter _data = ProductCategoryFilter();

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
        Button(
            text: "Search",
            onClick: () =>
                context.read<ListPageProvider>().searchEvent.publish(_data))
      ],
    );
  }
}
