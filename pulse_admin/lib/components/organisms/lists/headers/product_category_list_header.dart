import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/text/labels/list_heading.dart';

class ProductCategoryListHeader extends StatelessWidget {
  const ProductCategoryListHeader({super.key});

  @override
  Widget build(BuildContext context) {
    return const Row(
      children: [
        ListHeading("Product Category Id", 30),
        ListHeading("Name", 70),
      ],
    );
  }
}
