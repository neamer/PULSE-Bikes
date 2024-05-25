import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/product_image/product_image.dart';
import 'package:pulse_admin/components/atoms/images/image_add_button.dart';
import 'package:pulse_admin/components/atoms/images/image_tile.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class ImageFieldGroup extends StatefulWidget {
  final bool enabled;
  final int productId;
  final List<ProductImage> initialItems;

  const ImageFieldGroup(
      {super.key,
      required this.productId,
      required this.initialItems,
      this.enabled = true});

  @override
  State<ImageFieldGroup> createState() => _ImageFieldGroupState();
}

class _ImageFieldGroupState extends State<ImageFieldGroup> {
  List<ProductImage> _items = [];

  @override
  void initState() {
    super.initState();
    _items = widget.initialItems;
  }

  void onSuccess(ProductImage item) {
    setState(() {
      _items.add(item);
    });
  }

  void onDelete(ProductImage item) {
    setState(() {
      _items.remove(item);
    });
  }

  @override
  Widget build(BuildContext context) {
    return SpacedColumn(
        crossAxisAlignment: CrossAxisAlignment.start,
        spacing: Spacing.md,
        children: [
          const Padding(
            padding: EdgeInsets.only(left: Spacing.xs),
            child: FieldLabel("Images"),
          ),
          ClipRRect(
            borderRadius: BorderRadius.circular(Spacing.sm),
            child: Container(
              color: ColorTheme.m600,
              child: Padding(
                padding: const EdgeInsets.all(Spacing.sm),
                child: SizedBox(
                  height: 156 + Spacing.sm,
                  width: double.infinity,
                  child: SingleChildScrollView(
                    child: Wrap(
                      crossAxisAlignment: WrapCrossAlignment.center,
                      spacing: Spacing.md,
                      runSpacing: Spacing.sm,
                      direction: Axis.horizontal,
                      children: [
                        if (widget.enabled)
                          ImageAddButton(
                            productId: widget.productId,
                            onSuccess: onSuccess,
                          ),
                        ..._items.map((e) => ImageTile(
                              e,
                              enabled: widget.enabled,
                              onDelete: onDelete,
                            )),
                      ],
                    ),
                  ),
                ),
              ),
            ),
          )
        ]);
  }
}
