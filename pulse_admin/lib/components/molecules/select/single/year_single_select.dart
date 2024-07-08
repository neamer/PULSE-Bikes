import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/dropdown.dart';
import 'package:pulse_admin/domain/types/delegate.dart';

class YearSingleSelect extends StatefulWidget {
  final double width;
  final Delegate<int?> onChanged;
  final int? value;
  final int min;
  final int max;

  const YearSingleSelect(
      {super.key,
      required this.width,
      required this.onChanged,
      this.value,
      required this.min,
      required this.max});

  @override
  State<YearSingleSelect> createState() => _YearSingleSelectState();
}

class _YearSingleSelectState extends State<YearSingleSelect> {
  List<int> getOptions() {
    List<int> options = [];

    for (int i = widget.min; i <= widget.max; i++) {
      options.add(i);
    }

    return options;
  }

  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: Dropdown(
          items: getOptions(),
          value: widget.value,
          hintText: "Choose option",
          onChanged: widget.onChanged,
          renderOption: ((item) => Text(
                item.toString(),
                style: Theme.of(context).textTheme.bodyMedium,
              )),
        ));
  }
}
