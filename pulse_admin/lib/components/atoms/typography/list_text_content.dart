import 'package:flutter/material.dart';

class ListTextContent extends StatelessWidget {
  final String text;
  final int flex;
  final Color? color;

  const ListTextContent(this.text, this.flex, {super.key, this.color});

  @override
  Widget build(BuildContext context) {
    return Expanded(
      flex: flex,
      child: Text(
        text,
        style: Theme.of(context).textTheme.bodyMedium?.copyWith(color: color),
      ),
    );
  }
}
