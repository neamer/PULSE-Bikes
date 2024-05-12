import 'package:flutter/material.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_base.dart';

class SpacedColumn extends StatelessWidget with SpacedBase {
  final List<Widget> children;
  final double spacing;
  final MainAxisAlignment mainAxisAlignment;
  final CrossAxisAlignment crossAxisAlignment;
  final MainAxisSize mainAxisSize;

  const SpacedColumn(
      {super.key,
      required this.children,
      required this.spacing,
      this.mainAxisAlignment = MainAxisAlignment.start,
      this.crossAxisAlignment = CrossAxisAlignment.center,
      this.mainAxisSize = MainAxisSize.max});

  @override
  Widget build(BuildContext context) {
    return Column(
        mainAxisSize: mainAxisSize,
        mainAxisAlignment: mainAxisAlignment,
        crossAxisAlignment: crossAxisAlignment,
        children: buildSpacedChildren(children, spacing));
  }
}
