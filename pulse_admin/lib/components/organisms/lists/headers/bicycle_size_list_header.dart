import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_heading.dart';

class BicycleSizeListHeader extends StatelessWidget {
  const BicycleSizeListHeader({super.key});

  @override
  Widget build(BuildContext context) {
    return const Row(
      children: [
        ListHeading("Id", 30),
        ListHeading("Size", 70),
      ],
    );
  }
}
