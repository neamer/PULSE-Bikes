import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/colors.dart';

enum FieldLabelSize { sm, md, lg }

class FieldLabel extends StatelessWidget {
  final String text;
  final FieldLabelSize size;
  final Color color;

  const FieldLabel(this.text,
      {super.key, this.size = FieldLabelSize.sm, this.color = ColorTheme.n500});

  double getFontSize() {
    switch (size) {
      case FieldLabelSize.md:
        return 16;
      case FieldLabelSize.lg:
        return 18;
      default:
        return 14;
    }
  }

  @override
  Widget build(BuildContext context) {
    return Text(text,
        style: Theme.of(context)
            .textTheme
            .titleSmall
            ?.copyWith(color: color, fontSize: getFontSize()));
  }
}
