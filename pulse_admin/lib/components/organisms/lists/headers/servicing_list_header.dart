import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_heading.dart';

class ServicingListHeader extends StatelessWidget {
  const ServicingListHeader({super.key});

  @override
  Widget build(BuildContext context) {
    return const Row(
      children: [
        ListHeading("Servicing Number", 25),
        ListHeading("Status", 25),
        ListHeading("Customer", 25),
        ListHeading("Created At", 25),
      ],
    );
  }
}
