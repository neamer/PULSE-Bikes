import 'package:flutter/material.dart';
import 'package:fluttertoast/fluttertoast.dart';
import 'package:pulse_admin/components/molecules/toast/error_toast.dart';
import 'package:pulse_admin/components/molecules/toast/success_toast.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/core/style/timing.dart';

void successToast(BuildContext context, String message) {
  var fToast = FToast();
  fToast.init(context);
  fToast.showToast(
      child: SuccessToast(
        message: message,
      ),
      gravity: ToastGravity.BOTTOM,
      toastDuration: const Duration(seconds: AppTiming.successToastDuration),
      positionedToastBuilder: (context, child) {
        return Positioned(bottom: Spacing.lg, right: Spacing.lg, child: child);
      });
}

void errorToast(BuildContext context, String message) {
  var fToast = FToast();
  fToast.init(context);
  fToast.showToast(
      child: ErrorToast(
        message: message,
      ),
      gravity: ToastGravity.BOTTOM,
      toastDuration: const Duration(seconds: AppTiming.errorToastDuration),
      positionedToastBuilder: (context, child) {
        return Positioned(bottom: Spacing.lg, right: Spacing.lg, child: child);
      });
}
