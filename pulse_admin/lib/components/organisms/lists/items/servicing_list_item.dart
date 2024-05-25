import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:pulse_admin/api/types/servicing/servicing.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/core/style/colors.dart';

class ServicingListItem extends StatelessWidget {
  final Servicing data;
  final VoidCallback? onClick;
  final List<Widget>? actions;

  const ServicingListItem(this.data, {Key? key, this.onClick, this.actions})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      onClick: onClick,
      actions: actions,
      children: [
        ListTextContent(
          data.servicingNumber ?? "N/A",
          25,
          color: data.servicingNumber == null ? ColorTheme.n500 : null,
        ),
        ListTextContent(data.statusNamee ?? "", 25),
        ListTextContent(data.customer.toString(), 25),
        ListTextContent(DateFormat.yMMMd().format(data.createdAt!), 25),
      ],
    );
  }
}
