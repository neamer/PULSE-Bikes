import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/bicycle/bicycle.dart';
import 'package:pulse_admin/components/atoms/typography/list_text_content.dart';
import 'package:pulse_admin/components/organisms/lists/items/list_item_base.dart';
import 'package:pulse_admin/core/style/colors.dart';

class BicycleListItem extends StatelessWidget {
  final Bicycle data;
  final VoidCallback onClick;
  final List<Widget>? actions;

  const BicycleListItem(this.data,
      {Key? key, required this.onClick, this.actions})
      : super(key: key);

  bool isAvailable() =>
      data.availableSizes != null && data.availableSizes!.isNotEmpty;

  String formatSizes() {
    if (isAvailable()) {
      return data.availableSizes!
          .where((e) => e.availableQty != null && e.availableQty! > 0)
          .map((e) => e.bicycleSize?.size ?? "")
          .join(", ");
    } else {
      return "N/A";
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListItemBase(
      onClick: onClick,
      actions: actions,
      children: [
        ListTextContent(data.productNumber ?? "", 19),
        ListTextContent(data.brand.toString(), 14),
        ListTextContent(data.model ?? "", 25),
        ListTextContent(data.productCategory.toString(), 17),
        ListTextContent(
          formatSizes(),
          15,
          color: isAvailable() ? null : ColorTheme.n500,
        ),
        ListTextContent(data.price?.toStringAsFixed(2) ?? "", 10),
      ],
    );
  }
}
