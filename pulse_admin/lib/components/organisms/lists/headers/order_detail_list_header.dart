import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_heading.dart';

class OrderDetailListHeader extends StatelessWidget {
  const OrderDetailListHeader({super.key});

  @override
  Widget build(BuildContext context) {
    return const Row(
      children: [
        ListHeading("Product number", 25),
        ListHeading("Brand", 15),
        ListHeading("Model", 32),
        ListHeading("Quantity", 15),
        ListHeading("Unit price", 13),
      ],
    );
  }
}
