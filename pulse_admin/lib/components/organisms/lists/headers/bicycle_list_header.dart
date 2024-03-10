import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/text/labels/list_heading.dart';

class BicycleListHeader extends StatelessWidget {
  const BicycleListHeader({super.key});

  @override
  Widget build(BuildContext context) {
    return const Row(
      children: [
        ListHeading("Product Number", 17),
        ListHeading("Brand", 14),
        ListHeading("Model", 25),
        ListHeading("Category", 16),
        ListHeading("Sizes", 14),
        ListHeading("Price", 14),
      ],
    );
  }
}
