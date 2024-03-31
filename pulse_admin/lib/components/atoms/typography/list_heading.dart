import 'package:flutter/material.dart';

enum ListHeadingSize { sm, md, lg }

class ListHeading extends StatelessWidget {
  final ListHeadingSize size;
  final Color color;
  final String text;
  final int flex;

  const ListHeading(this.text, this.flex,
      {super.key,
      this.size = ListHeadingSize.md,
      this.color = const Color.fromRGBO(188, 188, 188, 1)});

  @override
  Widget build(BuildContext context) {
    return Expanded(
      flex: flex,
      child: Text(
        text,
        style: Theme.of(context).textTheme.titleSmall?.copyWith(
            fontSize: size == ListHeadingSize.md ? 16 : 14, color: color),
      ),
    );
  }
}
