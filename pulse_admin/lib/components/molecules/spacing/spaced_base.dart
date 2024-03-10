import 'package:flutter/material.dart';

mixin SpacedBase {
  List<Widget> buildSpacedChildren(List<Widget> children, double spacing) {
    final Iterator<Widget> iterator = children.iterator;
    final List<Widget> spacedChildren = [];

    if (iterator.moveNext()) {
      spacedChildren.add(iterator.current);
    }

    while (iterator.moveNext()) {
      spacedChildren.add(SizedBox(
        height: spacing,
        width: spacing,
      ));
      spacedChildren.add(iterator.current);
    }

    return spacedChildren;
  }
}
