import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/molecules/select/single/generic_single_select.dart';
import 'package:pulse_admin/core/types/delegate.dart';
import 'package:pulse_admin/data/product_category/product_category.dart';
import 'package:pulse_admin/providers/http/gear_category_provider.dart';

class GearCategorySingleSelect extends StatefulWidget {
  final double width;
  final Delegate<ProductCategory?> onChanged;
  final ProductCategory? value;

  const GearCategorySingleSelect(
      {super.key, required this.width, required this.onChanged, this.value});

  @override
  State<GearCategorySingleSelect> createState() =>
      _GearCategorySingleSelectState();
}

class _GearCategorySingleSelectState extends State<GearCategorySingleSelect> {
  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: SingleSelect<ProductCategory>(
          onChanged: widget.onChanged,
          value: widget.value,
          text: "Category",
          renderOption: ((item) => SizedBox(
                width: widget.width,
                child: Text(
                  item.toString(),
                  style: Theme.of(context).textTheme.bodyMedium,
                ),
              )),
          fetch: () => context.read<GearCategoryProvider>().get(),
        ));
  }
}
