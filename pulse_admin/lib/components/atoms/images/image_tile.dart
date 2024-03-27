import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/product_image/product_image.dart';

class ImageTile extends StatefulWidget {
  final ProductImage _data;

  const ImageTile(this._data, {super.key});

  @override
  State<ImageTile> createState() => _ImageTileState();
}

class _ImageTileState extends State<ImageTile> {
  bool isHovered = false;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.only(bottom: Spacing.md),
      child: MouseRegion(
        onEnter: (event) {
          setState(() {
            isHovered = true;
          });
        },
        onExit: (event) {
          setState(() {
            isHovered = false;
          });
        },
        child: InkWell(
          customBorder: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(Spacing.sm),
          ),
          onTap: () {},
          child: Container(
            decoration: BoxDecoration(
              color: isHovered ? ColorTheme.m600 : ColorTheme.m700,
              borderRadius: BorderRadius.circular(Spacing.sm),
            ),
            child: Container(width: 100, height: 100),
          ),
        ),
      ),
    );
  }
}
