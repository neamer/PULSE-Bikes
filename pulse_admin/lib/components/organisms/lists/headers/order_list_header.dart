import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_heading.dart';

class OrderListHeader extends StatelessWidget {
  const OrderListHeader({super.key});

  @override
  Widget build(BuildContext context) {
    return const Row(
      children: [
        ListHeading("Order Number", 17),
        ListHeading("Processed", 17),
        ListHeading("Status", 17),
        ListHeading("Customer", 17),
        ListHeading("No. of items", 15),
        ListHeading("Total", 11),
      ],
    );
  }
}
