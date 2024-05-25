import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:pulse_admin/api/types/orders/order_header.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/core/style/colors.dart';

class OrderListItem extends StatelessWidget {
  final OrderHeader data;
  final VoidCallback onClick;
  final List<Widget>? actions;

  const OrderListItem(this.data,
      {Key? key, required this.onClick, this.actions})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      onClick: onClick,
      actions: actions,
      children: [
        ListTextContent(
          data.orderNumber ?? "N/A",
          17,
          color: data.orderNumber == null ? ColorTheme.n500 : null,
        ),
        ListTextContent(
            DateFormat.yMMMd().format(data.timeProcessed ?? DateTime.now()),
            17),
        ListTextContent(data.statusNamee ?? "", 17),
        ListTextContent(data.customer.toString(), 17),
        ListTextContent(data.orderDetails.length.toString(), 15),
        ListTextContent(data.getTotal().toStringAsFixed(2), 11),
      ],
    );
  }
}
