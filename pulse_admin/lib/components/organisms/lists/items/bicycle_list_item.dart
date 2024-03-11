import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/data/bicycle/bicycle.dart';

class BicycleListItem extends StatelessWidget {
  final Bicycle data;

  const BicycleListItem(this.data, {Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      children: [
        ListTextContent(data.productNumber ?? "", 17),
        ListTextContent(data.brand.toString(), 14),
        ListTextContent(data.model ?? "", 25),
        ListTextContent(data.productCategory.toString(), 16),
        ListTextContent("X, M, L", 14),
        ListTextContent(data.price?.toStringAsFixed(2) ?? "", 14),
      ],
    );
  }
}
