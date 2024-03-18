import 'package:flutter/material.dart';
import 'package:pulse_admin/components/molecules/toast/toast_base.dart';
import 'package:pulse_admin/core/style/colors.dart';

class SuccessToast extends StatelessWidget {
  final String message;

  const SuccessToast({Key? key, required this.message}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ToastBase(
        message: message,
        icon: const Icon(
          Icons.check_circle_outline,
          color: ColorTheme.g400,
        ));
  }
}
