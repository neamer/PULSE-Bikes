import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/bicycle/bicycle.dart';
import 'package:pulse_admin/api/types/orders/order_detail.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';

class OrderDetailListItem extends StatelessWidget {
  final OrderDetail data;
  final VoidCallback? onClick;
  final List<Widget>? actions;

  const OrderDetailListItem(this.data,
      {Key? key, required this.onClick, this.actions})
      : super(key: key);

  String formatModel() {
    if (data.product?.getDiscriminator() == Bicycle.discriminator) {
      return "${data.product} - ${data.bicycleSize}";
    } else {
      return data.product.toString();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      onClick: onClick,
      actions: actions,
      children: [
        ListTextContent(data.product?.productNumber ?? "", 25),
        ListTextContent(data.product?.brand?.name ?? "", 15),
        ListTextContent(formatModel(), 32),
        ListTextContent(data.quantity.toString(), 15),
        ListTextContent(data.unitPrice.toString(), 13),
      ],
    );
  }
}
