import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/user/customer.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';

class CustomerListItem extends StatelessWidget {
  final Customer data;
  final VoidCallback onClick;
  final List<Widget>? actions;

  const CustomerListItem(this.data,
      {Key? key, required this.onClick, this.actions})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      onClick: onClick,
      actions: actions,
      children: [
        ListTextContent(data.id.toString(), 10),
        ListTextContent(data.toString(), 25),
        ListTextContent(data.username ?? "", 25),
        ListTextContent(data.email ?? "", 40),
      ],
    );
  }
}
