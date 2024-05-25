import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/gear/gear.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';

class GearListItem extends StatelessWidget {
  final Gear data;
  final VoidCallback onClick;
  final List<Widget>? actions;

  const GearListItem(this.data, {Key? key, required this.onClick, this.actions})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      onClick: onClick,
      actions: actions,
      children: [
        ListTextContent(data.productNumber ?? "", 17),
        ListTextContent(data.brand.toString(), 14),
        ListTextContent(data.model ?? "", 25),
        ListTextContent(data.productCategory.toString(), 16),
        ListTextContent(data.availableQty.toString(), 18),
        ListTextContent(data.price?.toStringAsFixed(2) ?? "", 10),
      ],
    );
  }
}
