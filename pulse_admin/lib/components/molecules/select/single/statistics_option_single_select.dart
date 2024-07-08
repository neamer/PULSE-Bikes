import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/dropdown.dart';
import 'package:pulse_admin/domain/types/delegate.dart';
import 'package:pulse_admin/domain/types/statistics_option.dart';

class StatisticsOptionSingleSelect extends StatefulWidget {
  final double width;
  final Delegate<StatisticsOption?> onChanged;
  final StatisticsOption? value;

  const StatisticsOptionSingleSelect(
      {super.key, required this.width, required this.onChanged, this.value});

  @override
  State<StatisticsOptionSingleSelect> createState() =>
      _StatisticsOptionSingleSelectState();
}

class _StatisticsOptionSingleSelectState
    extends State<StatisticsOptionSingleSelect> {
  String formatOption(StatisticsOption item) {
    switch (item) {
      case StatisticsOption.salesByMonth:
        return "Sales by month";
      case StatisticsOption.revenueByMonth:
        return "Revenue by month";
      case StatisticsOption.bikesSoldByType:
        return "Bikes sold by type";
      case StatisticsOption.bikesSoldByPrice:
        return "Bikes sold by price";
      default:
        return "N/A";
    }
  }

  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: Dropdown(
          items: StatisticsOption.values,
          value: widget.value,
          hintText: "Choose option",
          onChanged: widget.onChanged,
          renderOption: ((item) => Text(
                formatOption(item),
                style: Theme.of(context).textTheme.bodyMedium,
              )),
        ));
  }
}
