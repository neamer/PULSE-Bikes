import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/data/product_category/product_category.dart';

class ProductCategoryListItem extends StatelessWidget {
  final ProductCategory data;
  final VoidCallback onClick;
  final List<Widget>? actions;

  const ProductCategoryListItem(this.data,
      {Key? key, this.actions, required this.onClick})
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
