import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/dropdown.dart';
import 'package:pulse_admin/domain/types/delegate.dart';

class StatusSingleSelect extends StatefulWidget {
  final double width;
  final Delegate<bool?> onChanged;
  final bool? value;

  const StatusSingleSelect(
      {super.key, required this.width, required this.onChanged, this.value});

  @override
  State<StatusSingleSelect> createState() => _StatusSingleSelectState();
}

class _StatusSingleSelectState extends State<StatusSingleSelect> {
  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: Dropdown(
          items: List.of([true, false]),
          value: widget.value,
          hintText: "Status",
          onChanged: widget.onChanged,
          renderOption: ((item) => Text(
                item == true ? "Active" : "Inactive",
                style: Theme.of(context).textTheme.bodyMedium,
              )),
        ));
  }
}
