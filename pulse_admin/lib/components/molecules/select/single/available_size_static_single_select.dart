import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/dropdown.dart';
import 'package:pulse_admin/core/types/delegate.dart';
import 'package:pulse_admin/data/available_size/available_size.dart';

class AvailableSizeStaticSingleSelect extends StatefulWidget {
  final String text;
  final bool enabled;
  final bool clearable;
  final double width;
  final Delegate<AvailableSize?> onChanged;
  final List<AvailableSize> items;
  final AvailableSize? value;

  const AvailableSizeStaticSingleSelect(
      {super.key,
      required this.width,
      required this.onChanged,
      this.value,
      this.enabled = true,
      this.clearable = false,
      this.text = "Bicycle size",
      required this.items});

  @override
  State<AvailableSizeStaticSingleSelect> createState() =>
      _AvailableSizeSingleSelectState();
}

class _AvailableSizeSingleSelectState
    extends State<AvailableSizeStaticSingleSelect> {
  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: Dropdown<AvailableSize>(
          clearable: widget.clearable,
          enabled: widget.enabled,
          onChanged: widget.onChanged,
          value: widget.value,
          hintText: widget.text,
          renderOption: ((item) => SizedBox(
                child: Text(
                  item.toString(),
                  style: Theme.of(context).textTheme.bodyMedium,
                ),
              )),
          items: widget.items,
        ));
  }
}
