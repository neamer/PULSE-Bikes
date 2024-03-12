import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/data/orders/order_header.dart';

class OrderListItem extends StatelessWidget {
  final OrderHeader data;

  const OrderListItem(this.data, {Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      children: [
        ListTextContent(data.orderNumber ?? "", 17),
        ListTextContent(DateFormat.yMMMd().format(data.timeProcessed!), 17),
        ListTextContent(data.statusNamee ?? "", 17),
        ListTextContent(data.customer.toString(), 17),
        ListTextContent(data.orderDetails.length.toString(), 15),
        ListTextContent(data.getTotal().toStringAsFixed(2) ?? "", 11),
      ],
    );
  }
}
