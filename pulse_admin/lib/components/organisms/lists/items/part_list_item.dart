import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/text/labels/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/data/part/part.dart';

class PartListItem extends StatelessWidget {
  final Part data;

  const PartListItem(this.data, {Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
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
