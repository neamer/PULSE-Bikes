import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/available_size/available_size.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/core/style/colors.dart';

class AvailableSizeListItem extends StatelessWidget {
  final AvailableSize data;
  final VoidCallback? onClick;
  final List<Widget>? actions;

  const AvailableSizeListItem(this.data,
      {Key? key, required this.onClick, this.actions})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      backgroundColor: ColorTheme.m600,
      hoverColor: ColorTheme.m600,
      onClick: onClick,
      actions: actions,
      children: [
        ListTextContent(data.bicycleSize.toString(), 50),
        ListTextContent(data.availableQty.toString(), 50),
      ],
    );
  }
}
