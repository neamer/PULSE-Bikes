import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_heading.dart';

class CustomerListHeader extends StatelessWidget {
  const CustomerListHeader({super.key});

  @override
  Widget build(BuildContext context) {
    return const Row(
      children: [
        ListHeading("Id", 10),
        ListHeading("Name", 25),
        ListHeading("Username", 25),
        ListHeading("Email", 40),
      ],
    );
  }
}
