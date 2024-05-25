import 'dart:io';
import 'dart:ui';

import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/product_image_provider.dart';
import 'package:pulse_admin/api/types/product_image/product_image.dart';
import 'package:pulse_admin/api/types/product_image/product_image_insert_request.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class ImageAddButton extends StatefulWidget {
  final int productId;
  final Function(ProductImage item) onSuccess;
  const ImageAddButton(
      {super.key, required this.productId, required this.onSuccess});
  @override
  State<ImageAddButton> createState() => _ImageAddButtonState();
}

class _ImageAddButtonState extends State<ImageAddButton> {
  bool isHovered = false;

  File? _image;
  final picker = ImagePicker();

  Future pickImage() async {
    final pickedFile = await picker.pickImage(source: ImageSource.gallery);

    setState(() {
      if (pickedFile != null) {
        _image = File(pickedFile.path);
      }
    });

    uploadImage();
  }

  Future uploadImage() async {
    if (_image == null) return;

    await genericRequestHandler(context, () async {
      var result = await context.read<ProductImageProvider>().insert(
          ProductImageInsertRequest.fromFile(_image!, widget.productId));
      if (result != null) {
        widget.onSuccess(result);
      }
    })();

    setState(() {
      _image = null;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MouseRegion(
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
        onTap: _image == null ? pickImage : null,
        child: Container(
          decoration: BoxDecoration(
            color: isHovered ? ColorTheme.m450 : ColorTheme.m500,
            borderRadius: BorderRadius.circular(Spacing.sm),
          ),
          child: SizedBox(
            width: 78,
            height: 78,
            child: _image == null
                ? const Icon(
                    Icons.upload,
                    size: 25,
                    color: ColorTheme.n500,
                  )
                : Stack(
                    children: [
                      ClipRRect(
                        borderRadius: BorderRadius.circular(Spacing.sm),
                        child: SizedBox(
                          width: 78,
                          height: 78,
                          child: Image.file(_image!, fit: BoxFit.cover),
                        ),
                      ),
                      ClipRRect(
                          borderRadius: BorderRadius.circular(Spacing.sm),
                          child: BackdropFilter(
                              filter: ImageFilter.blur(sigmaX: 4, sigmaY: 4),
                              child: Positioned.fill(
                                child: Container(
                                  color: Colors.black.withAlpha(100),
                                ),
                              ))),
                      const Positioned.fill(
                        child: Center(
                          child: SizedBox(
                            height: 20,
                            width: 20,
                            child: CircularProgressIndicator(
                              color: ColorTheme.n500,
                              strokeWidth: 2.5,
                            ),
                          ),
                        ),
                      ),
                    ],
                  ),
          ),
        ),
      ),
    );
  }
}
