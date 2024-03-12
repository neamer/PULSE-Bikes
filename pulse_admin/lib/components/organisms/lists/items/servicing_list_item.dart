import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/data/servicing/servicing.dart';

class ServicingListItem extends StatelessWidget {
  final Servicing data;

  const ServicingListItem(this.data, {Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      children: [
        ListTextContent(data.servicingNumber ?? "", 25),
        ListTextContent(data.statusNamee ?? "", 25),
        ListTextContent(data.customer.toString(), 25),
        ListTextContent(DateFormat.yMMMd().format(data.createdAt!), 17),
      ],
    );
  }
}
