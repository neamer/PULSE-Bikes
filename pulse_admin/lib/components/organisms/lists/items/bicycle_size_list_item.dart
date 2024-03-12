import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/data/bicycle_size/bicycle_size.dart';

class BicycleSizeListItem extends StatelessWidget {
  final BicycleSize data;

  const BicycleSizeListItem(this.data, {Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      children: [
        ListTextContent(data.id.toString(), 30),
        ListTextContent(data.size ?? "", 70),
      ],
    );
  }
}
