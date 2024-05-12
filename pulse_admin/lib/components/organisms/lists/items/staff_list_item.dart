import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/data/user/staff.dart';

class StaffListItem extends StatelessWidget {
  final Staff data;
  final VoidCallback onClick;
  final List<Widget> actions;

  const StaffListItem(this.data,
      {Key? key, required this.onClick, required this.actions})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      onClick: onClick,
      actions: actions,
      children: [
        ListTextContent(data.id.toString(), 19),
        ListTextContent(data.toString(), 27),
        ListTextContent(data.status == true ? "Active" : "Inactive", 27),
        ListTextContent(data.role?.name ?? "", 27),
      ],
    );
  }
}
