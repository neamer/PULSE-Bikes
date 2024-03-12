import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/dropdown.dart';
import 'package:pulse_admin/core/types/delegate.dart';
import 'package:pulse_admin/data/orders/order_header.dart';

class OrderStatusSingleSelect extends StatefulWidget {
  final double width;
  final Delegate<OrderStatus?> onChanged;
  final OrderStatus? value;

  const OrderStatusSingleSelect(
      {super.key, required this.width, required this.onChanged, this.value});

  @override
  State<OrderStatusSingleSelect> createState() =>
      _OrderStatusSingleSelectState();
}

class _OrderStatusSingleSelectState extends State<OrderStatusSingleSelect> {
  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: Dropdown(
          items: OrderStatus.values,
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
