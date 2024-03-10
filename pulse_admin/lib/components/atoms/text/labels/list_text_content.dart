import 'package:flutter/material.dart';

class ListTextContent extends StatelessWidget {
  final String text;
  final int flex;

  const ListTextContent(this.text, this.flex, {super.key});

  @override
  Widget build(BuildContext context) {
    return Expanded(
      flex: flex,
      child: Text(
        text,
        style: Theme.of(context).textTheme.bodyMedium,
      ),
    );
  }
}
