import 'package:flutter/material.dart';
import 'package:pulse_admin/components/molecules/toast/toast_base.dart';
import 'package:pulse_admin/core/style/colors.dart';

class ErrorToast extends StatelessWidget {
  final String message;

  const ErrorToast({Key? key, required this.message}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ToastBase(
        message: message,
        icon: const Icon(
          Icons.error_outline,
          color: ColorTheme.r400,
        ));
  }
}
