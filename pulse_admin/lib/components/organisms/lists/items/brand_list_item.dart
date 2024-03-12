import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/data/brand/brand.dart';

class BrandListItem extends StatelessWidget {
  final Brand data;

  const BrandListItem(this.data, {Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      children: [
        ListTextContent(data.id.toString(), 30),
        ListTextContent(data.name ?? "", 70),
      ],
    );
  }
}
