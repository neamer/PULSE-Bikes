import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/buttons/ghost_button.dart';
import 'package:pulse_admin/components/organisms/dialog/base/dialog_base.dart';
import 'package:pulse_admin/core/http/request_state.dart';
import 'package:pulse_admin/core/style/colors.dart';

class ConfirmDeletionDialog extends StatefulWidget {
  final Future Function() onDelete;

  const ConfirmDeletionDialog({super.key, required this.onDelete});

  @override
  State<ConfirmDeletionDialog> createState() => _ConfirmDeletionDialogState();
}

class _ConfirmDeletionDialogState extends State<ConfirmDeletionDialog> {
  RequestState _deletionState = RequestState.init;

  Future<void> handleConfirmClicked() async {
    setState(() {
      _deletionState = RequestState.loading;
    });

    await widget.onDelete();

    Navigator.of(context).pop();
  }

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return DialogBase(
      icon: Icons.error_outline,
      title: "Confirm Deletion",
      content: Text(
        "Are you sure you want to delete this item?",
        style: themeData.textTheme.bodyMedium?.copyWith(color: ColorTheme.n500),
      ),
      actions: [
        SizedBox(
          width: 100,
          child: Button(
            color: ColorTheme.r400,
            text: "Delete",
            loading: _deletionState == RequestState.loading,
            onClick: handleConfirmClicked,
          ),
        ),
        SizedBox(
          width: 100,
          child: GhostButton(
            color: ColorTheme.n700,
            text: "Cancel",
            onClick: () {
              Navigator.of(context).pop();
            },
          ),
        ),
      ],
    );
  }
}
