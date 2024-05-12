import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/core/types/list_item.dart';

class InlineList<T> extends StatelessWidget {
  final Widget? listHeader;
  final ListItem<T> itemBuilder;
  final List<T> data;
  final bool scrollable;

  const InlineList(
      {super.key,
      required this.itemBuilder,
      this.listHeader,
      required this.data,
      this.scrollable = false});

  @override
  Widget build(BuildContext context) {
    return Column(children: [
      if (listHeader != null)
        Padding(
            padding: const EdgeInsets.only(
                left: Spacing.lg,
                right: Spacing.lg,
                top: Spacing.sm,
                bottom: Spacing.md),
            child: listHeader!),
      scrollable
          ? ListView.builder(
              shrinkWrap: false,
              physics: const ScrollPhysics(),
              itemCount: data.length,
              itemBuilder: (ctx, index) => itemBuilder(
                data[index],
              ),
            )
          : Column(
              mainAxisSize: MainAxisSize.min,
              children: data.map((item) => itemBuilder(item)).toList(),
            )
    ]);
  }
}
