import 'package:flutter/material.dart';
import 'package:pulse_admin/components/organisms/dialog/available_size_add_dialog.dart';
import 'package:pulse_admin/components/organisms/dialog/available_size_edit_dialog.dart';
import 'package:pulse_admin/components/organisms/dialog/available_size_select_dialog.dart';
import 'package:pulse_admin/components/organisms/dialog/order_detail_edit_dialog.dart';
import 'package:pulse_admin/components/organisms/dialog/servicing_part_edit_dialog.dart';
import 'package:pulse_admin/data/available_size/available_size.dart';
import 'package:pulse_admin/data/orders/order_detail.dart';
import 'package:pulse_admin/data/servicing/servicing_part.dart';

void showAvailableSizeEditDialog(
    {required BuildContext context,
    required AvailableSize initialValues,
    required void Function(AvailableSize) onSuccess}) {
  showDialog(
    context: context,
    builder: (BuildContext context) {
      return AvailableSizeEditDialog(
        initialValues: initialValues,
        onSuccess: onSuccess,
      );
    },
  );
}

void showAvailableSizeAddDialog(
    {required BuildContext context,
    required int productId,
    required void Function(AvailableSize) onSuccess}) {
  showDialog(
    context: context,
    builder: (BuildContext context) {
      return AvailableSizeAddDialog(onSuccess: onSuccess, productId: productId);
    },
  );
}

void showAvailableSizeSelectDialog(
    {required BuildContext context,
    required List<AvailableSize> options,
    required void Function(AvailableSize) onSuccess}) {
  showDialog(
    context: context,
    builder: (BuildContext context) {
      return AvailableSizeSelectDialog(
        options: options,
        onSuccess: onSuccess,
      );
    },
  );
}

void showOrderDetailEditDialog(
    {required BuildContext context,
    required OrderDetail initialValues,
    required void Function(OrderDetail) onSuccess}) {
  showDialog(
    context: context,
    builder: (BuildContext context) {
      return OrderDetailEditDialog(
        initialValues: initialValues,
        onSuccess: onSuccess,
      );
    },
  );
}

void showServicingPartEditDialog(
    {required BuildContext context,
    required ServicingPart initialValues,
    required void Function(ServicingPart) onSuccess}) {
  showDialog(
    context: context,
    builder: (BuildContext context) {
      return ServicingPartEditDialog(
        initialValues: initialValues,
        onSuccess: onSuccess,
      );
    },
  );
}
