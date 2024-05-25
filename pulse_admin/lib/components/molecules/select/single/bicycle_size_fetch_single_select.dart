import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/bicycle_size_provider.dart';
import 'package:pulse_admin/api/types/bicycle_size/bicycle_size.dart';
import 'package:pulse_admin/components/molecules/select/single/abstract_single_select.dart';
import 'package:pulse_admin/components/molecules/select/single/generic_single_select.dart';

class BicycleSizeFetchSingleSelect extends AbstractSingleSelect {
  const BicycleSizeFetchSingleSelect(
      {super.key,
      required super.width,
      required super.onChanged,
      super.value,
      super.enabled,
      super.clearable,
      super.text = "Bicycle size"});

  @override
  State<BicycleSizeFetchSingleSelect> createState() =>
      _BicycleSizeSingleSelectState();
}

class _BicycleSizeSingleSelectState
    extends State<BicycleSizeFetchSingleSelect> {
  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: SingleSelect<BicycleSize>(
          clearable: widget.clearable,
          enabled: widget.enabled,
          onChanged: widget.onChanged,
          value: widget.value,
          text: widget.text,
          renderOption: ((item) => SizedBox(
                child: Text(
                  item.toString(),
                  style: Theme.of(context).textTheme.bodyMedium,
                ),
              )),
          fetch: () => context.read<BicycleSizeProvider>().get(),
        ));
  }
}
