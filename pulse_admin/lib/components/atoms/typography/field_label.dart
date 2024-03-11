import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/colors.dart';

class FieldLabel extends StatelessWidget {
  final String text;

  const FieldLabel(this.text, {super.key});

  @override
  Widget build(BuildContext context) {
    return Text(text,
        style: Theme.of(context)
            .textTheme
            .titleSmall
            ?.copyWith(color: ColorTheme.n500, fontSize: 14));
  }
}
