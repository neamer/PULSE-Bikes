import 'package:flutter/material.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_base.dart';

class SpacedColumn extends StatelessWidget with SpacedBase {
  final List<Widget> children;
  final double spacing;
  final MainAxisAlignment mainAxisAlignment;
  final CrossAxisAlignment crossAxisAlignment;

  const SpacedColumn(
      {super.key,
      required this.children,
      required this.spacing,
      this.mainAxisAlignment = MainAxisAlignment.start,
      this.crossAxisAlignment = CrossAxisAlignment.center});

  @override
  Widget build(BuildContext context) {
    return Column(
        mainAxisAlignment: mainAxisAlignment,
        crossAxisAlignment: crossAxisAlignment,
        children: buildSpacedChildren(children, spacing));
  }
}
