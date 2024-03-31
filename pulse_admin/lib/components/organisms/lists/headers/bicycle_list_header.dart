import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_heading.dart';

class BicycleListHeader extends StatelessWidget {
  const BicycleListHeader({super.key});

  @override
  Widget build(BuildContext context) {
    return const Row(
      children: [
        ListHeading("Product Number", 19),
        ListHeading("Brand", 14),
        ListHeading("Model", 25),
        ListHeading("Category", 17),
        ListHeading("Sizes", 15),
        ListHeading("Price", 10),
      ],
    );
  }
}
