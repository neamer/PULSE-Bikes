import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/product_image/product_image.dart';
import 'package:pulse_admin/providers/http/products/product_image_provider.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/image_util.dart';

class ImageTile extends StatefulWidget {
  final ProductImage _data;
  final bool enabled;
  final Function(ProductImage item)? onDelete;

  const ImageTile(this._data,
      {super.key, required this.enabled, this.onDelete});

  @override
  State<ImageTile> createState() => _ImageTileState();
}

class _ImageTileState extends State<ImageTile> {
  bool isHovered = false;

  Future deleteItem(BuildContext context) async {
    await context.read<ProductImageProvider>().delete(widget._data.id!);
    widget.onDelete?.call(widget._data);
  }

  @override
  Widget build(BuildContext context) {
    return MouseRegion(
      onEnter: (event) {
        if (!widget.enabled) return;

        setState(() {
          isHovered = true;
        });
      },
      onExit: (event) {
        if (!widget.enabled) return;

        setState(() {
          isHovered = false;
        });
      },
      child: ClipRRect(
        borderRadius: BorderRadius.circular(Spacing.sm),
        child: Container(
          decoration: BoxDecoration(
            color: ColorTheme.m700,
            borderRadius: BorderRadius.circular(Spacing.sm),
          ),
          child: Stack(
            children: [
              SizedBox(
                width: 78,
                height: 78,
                child: ImageUtil.imageFromBase64String(widget._data.data!),
              ),
              if (isHovered)
                Positioned.fill(
                  child: InkWell(
                    onTap: () {
                      showDeleteConfirmationDialog(
                          context,
                          genericRequestHandler(
                              context, () => deleteItem(context),
                              successMessage: "Successfully deleted image"));
                    },
                    child: Container(
                      color: Colors.black.withAlpha(100),
                      child: const Center(
                        child: Icon(
                          Icons.image_not_supported_sharp,
                          color: ColorTheme.r400,
                          size: 25,
                        ),
                      ),
                    ),
                  ),
                ),
            ],
          ),
        ),
      ),
    );
  }
}
