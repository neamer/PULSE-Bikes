import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_heading.dart';

class StaffListHeader extends StatelessWidget {
  const StaffListHeader({super.key});

  @override
  Widget build(BuildContext context) {
    return const Row(
      children: [
        ListHeading("Id", 19),
        ListHeading("Name", 27),
        ListHeading("Status", 27),
        ListHeading("Role", 27),
      ],
    );
  }
}
