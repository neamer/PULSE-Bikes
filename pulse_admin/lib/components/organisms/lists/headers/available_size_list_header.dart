import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_heading.dart';
import 'package:pulse_admin/core/style/colors.dart';

class AvailableSizeListHeader extends StatelessWidget {
  const AvailableSizeListHeader({super.key});

  @override
  Widget build(BuildContext context) {
    return const Row(
      children: [
        ListHeading(
          "Bicycle size",
          50,
          color: ColorTheme.n500,
          size: ListHeadingSize.sm,
        ),
        ListHeading(
          "Available quantity",
          50,
          color: ColorTheme.n500,
          size: ListHeadingSize.sm,
        ),
      ],
    );
  }
}
