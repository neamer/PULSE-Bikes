import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/core/types/list_item.dart';

class InlineList<T> extends StatelessWidget {
  final Widget? listHeader;
  final ListItem<T> itemBuilder;
  final List<T> data;

  const InlineList(
      {super.key,
      required this.itemBuilder,
      this.listHeader,
      required this.data});

  @override
  Widget build(BuildContext context) {
    return ListView(children: [
      if (listHeader != null)
        Padding(
            padding: const EdgeInsets.only(
                left: Spacing.lg,
                right: Spacing.lg,
                top: Spacing.sm,
                bottom: Spacing.md),
            child: listHeader!),
      ListView.builder(
        shrinkWrap: true,
        physics: const ScrollPhysics(),
        itemCount: data.length,
        itemBuilder: (ctx, index) => itemBuilder(
          data[index],
        ),
      )
    ]);
  }
}
