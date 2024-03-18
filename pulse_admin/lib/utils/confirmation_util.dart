import 'package:flutter/material.dart';
import 'package:pulse_admin/components/organisms/dialog/confirm_deletion_dialog.dart';

void showDeleteConfirmationDialog(
    BuildContext context, Future Function() onDelete) {
  showDialog(
    context: context,
    builder: (BuildContext context) {
      return ConfirmDeletionDialog(
        onDelete: onDelete,
      );
    },
  );
}
