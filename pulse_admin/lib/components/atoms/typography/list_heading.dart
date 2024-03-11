import 'package:flutter/material.dart';

class ListHeading extends StatelessWidget {
  final String text;
  final int flex;

  const ListHeading(this.text, this.flex, {super.key});

  @override
  Widget build(BuildContext context) {
    return Expanded(
      flex: flex,
      child: Text(
        text,
        style: Theme.of(context).textTheme.titleSmall,
      ),
    );
  }
}
