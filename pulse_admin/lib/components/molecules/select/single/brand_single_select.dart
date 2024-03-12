import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/molecules/select/single/generic_single_select.dart';
import 'package:pulse_admin/core/types/delegate.dart';
import 'package:pulse_admin/data/brand/brand.dart';
import 'package:pulse_admin/providers/http/products/brand_provider.dart';

class BrandSingleSelect extends StatefulWidget {
  final double width;
  final Delegate<Brand?> onChanged;
  final Brand? value;

  const BrandSingleSelect(
      {super.key, required this.width, required this.onChanged, this.value});

  @override
  State<BrandSingleSelect> createState() => _BrandSingleSelectState();
}

class _BrandSingleSelectState extends State<BrandSingleSelect> {
  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: SingleSelect<Brand>(
          onChanged: widget.onChanged,
          value: widget.value,
          text: "Brand",
          renderOption: ((item) => SizedBox(
                child: Text(
                  item.toString(),
                  style: Theme.of(context).textTheme.bodyMedium,
                ),
              )),
          fetch: () => context.read<BrandProvider>().get(),
        ));
  }
}
