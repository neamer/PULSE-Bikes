import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_heading.dart';

class ProductListHeader extends StatelessWidget {
  const ProductListHeader({super.key});

  @override
  Widget build(BuildContext context) {
    return const Row(
      children: [
        ListHeading("Product Number", 17),
        ListHeading("Brand", 14),
        ListHeading("Model", 25),
        ListHeading("Category", 16),
        ListHeading("Available Qty", 18),
        ListHeading("Price", 10),
      ],
    );
  }
}
