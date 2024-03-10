import 'package:flutter/material.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_base.dart';

class SpacedRow extends StatelessWidget with SpacedBase {
  final List<Widget> children;
  final double spacing;

  const SpacedRow({super.key, required this.children, required this.spacing});

  @override
  Widget build(BuildContext context) {
    return Row(children: buildSpacedChildren(children, spacing));
  }
}
