import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/part_category_provider.dart';
import 'package:pulse_admin/api/types/product_category/product_category.dart';
import 'package:pulse_admin/components/molecules/select/single/abstract_single_select.dart';
import 'package:pulse_admin/components/molecules/select/single/generic_single_select.dart';

class PartCategorySingleSelect extends AbstractSingleSelect {
  const PartCategorySingleSelect(
      {super.key,
      required super.width,
      required super.onChanged,
      super.value,
      super.enabled,
      super.clearable,
      super.text = "Category"});

  @override
  State<PartCategorySingleSelect> createState() =>
      _PartCategorySingleSelectState();
}

class _PartCategorySingleSelectState extends State<PartCategorySingleSelect> {
  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: SingleSelect<ProductCategory>(
          onChanged: widget.onChanged,
          clearable: widget.clearable,
          enabled: widget.enabled,
          value: widget.value,
          text: widget.text,
          renderOption: ((item) => SizedBox(
                child: Text(
                  item.toString(),
                  style: Theme.of(context).textTheme.bodyMedium,
                ),
              )),
          fetch: () => context.read<PartCategoryProvider>().get(),
        ));
  }
}
