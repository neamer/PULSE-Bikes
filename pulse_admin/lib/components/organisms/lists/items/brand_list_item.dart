import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/brand/brand.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';

class BrandListItem extends StatelessWidget {
  final Brand data;
  final VoidCallback onClick;
  final List<Widget>? actions;

  const BrandListItem(this.data,
      {Key? key, required this.onClick, this.actions})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      onClick: onClick,
      actions: actions,
      children: [
        ListTextContent(data.id.toString(), 30),
        ListTextContent(data.name ?? "", 70),
      ],
    );
  }
}
