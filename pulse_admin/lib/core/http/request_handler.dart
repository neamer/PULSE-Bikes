import 'package:flutter/material.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/utils/toast_utils.dart';

Future Function() genericErrorHandler(
    BuildContext context, Future Function() action) {
  return () async {
    try {
      await action();
    } catch (e) {
      errorToast(context, "An error occured!");
    }
  };
}

Future Function() genericRequestHandler(
    BuildContext context, Future Function() action,
    {String? successMessage, String? errorMessage}) {
  return () async {
    try {
      await action();
      successToast(context, successMessage ?? "Success!");
    } on ValidationException catch (e) {
      errorToast(context, e.msg ?? "There were errors in your form");
    } catch (e) {
      errorToast(context, errorMessage ?? "An error occured!");
    }
  };
}
