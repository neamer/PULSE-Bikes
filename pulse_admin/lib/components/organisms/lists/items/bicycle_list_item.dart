import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/data/bicycle/bicycle.dart';

class BicycleListItem extends StatelessWidget {
  final Bicycle data;
  final VoidCallback onClick;
  final List<Widget>? actions;

  const BicycleListItem(this.data,
      {Key? key, required this.onClick, this.actions})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      onClick: onClick,
      actions: actions,
      children: [
        ListTextContent(data.productNumber ?? "", 19),
        ListTextContent(data.brand.toString(), 14),
        ListTextContent(data.model ?? "", 25),
        ListTextContent(data.productCategory.toString(), 17),
        const ListTextContent("X, M, L", 15),
        ListTextContent(data.price?.toStringAsFixed(2) ?? "", 10),
      ],
    );
  }
}
