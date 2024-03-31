import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/organisms/lists/headers/available_size_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/available_size_list_item.dart';
import 'package:pulse_admin/components/templates/inline_list.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/available_size/available_size.dart';

class AvailableSizeFormGroup extends StatelessWidget {
  final List<AvailableSize> initialItems;

  const AvailableSizeFormGroup({super.key, required this.initialItems});

  @override
  Widget build(BuildContext context) {
    return SpacedColumn(
        crossAxisAlignment: CrossAxisAlignment.start,
        spacing: Spacing.md + 1,
        children: [
          const Padding(
            padding: EdgeInsets.only(left: Spacing.xs),
            child: FieldLabel("Available sizes"),
          ),
          ClipRRect(
              borderRadius: BorderRadius.circular(Spacing.sm),
              child: Container(
                  color: ColorTheme.m600,
                  child: Padding(
                      padding: const EdgeInsets.all(Spacing.sm),
                      child: SizedBox(
                        height: 220,
                        child: InlineList(
                            listHeader: const AvailableSizeListHeader(),
                            itemBuilder: (item) =>
                                AvailableSizeListItem(item, onClick: null),
                            data: initialItems),
                      ))))
        ]);
  }
}
