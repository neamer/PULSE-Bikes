import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/dropdown.dart';
import 'package:pulse_admin/core/types/delegate.dart';
import 'package:pulse_admin/data/servicing/servicing_status.dart';

class ServicingStatusSingleSelect extends StatefulWidget {
  final double width;
  final Delegate<ServicingStatus?> onChanged;
  final ServicingStatus? value;

  const ServicingStatusSingleSelect(
      {super.key, required this.width, required this.onChanged, this.value});

  @override
  State<ServicingStatusSingleSelect> createState() =>
      _ServicingStatusSingleSelectState();
}

class _ServicingStatusSingleSelectState
    extends State<ServicingStatusSingleSelect> {
  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: Dropdown(
          items: ServicingStatus.values,
          value: widget.value,
          hintText: "Status",
          onChanged: widget.onChanged,
          renderOption: ((item) => Text(
                item.getName(),
                style: Theme.of(context).textTheme.bodyMedium,
              )),
        ));
  }
}
