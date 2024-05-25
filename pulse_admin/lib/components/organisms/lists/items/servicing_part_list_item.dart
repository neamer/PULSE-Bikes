import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/servicing/servicing_part.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';

class ServicingPartListItem extends StatelessWidget {
  final ServicingPart data;
  final VoidCallback? onClick;
  final List<Widget>? actions;

  const ServicingPartListItem(this.data,
      {Key? key, required this.onClick, this.actions})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      onClick: onClick,
      actions: actions,
      children: [
        ListTextContent(data.product?.productNumber ?? "", 25),
        ListTextContent(data.product?.brand?.name ?? "", 15),
        ListTextContent(data.product?.model ?? "", 32),
        ListTextContent(data.quantity.toString(), 15),
        ListTextContent(data.unitPrice.toString(), 13),
      ],
    );
  }
}
