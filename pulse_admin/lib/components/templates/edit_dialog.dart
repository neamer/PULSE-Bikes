import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/buttons/ghost_button.dart';
import 'package:pulse_admin/components/organisms/dialog/base/dialog_base.dart';
import 'package:pulse_admin/core/http/request_state.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/sizes.dart';
import 'package:pulse_admin/core/style/spacing.dart';

enum FormDialogSize { sm, md, lg }

class FormDialog extends StatefulWidget {
  final Future Function() onSubmit;
  final Widget? content;
  final String title;
  final String actionText;
  final FormDialogSize size;
  final IconData icon;

  const FormDialog(
      {super.key,
      required this.onSubmit,
      required this.title,
      this.icon = Icons.edit_note,
      this.actionText = 'Submit',
      this.content,
      this.size = FormDialogSize.sm});

  @override
  State<FormDialog> createState() => _FormDialogState();
}

class _FormDialogState extends State<FormDialog> {
  RequestState _submitState = RequestState.init;

  Future<void> handleConfirmClicked() async {
    setState(() {
      _submitState = RequestState.loading;
    });

    await widget.onSubmit();

    Navigator.of(context).pop();
  }

  @override
  Widget build(BuildContext context) {
    return DialogBase(
      icon: widget.icon,
      title: widget.title,
      content: widget.content != null
          ? SizedBox(
              width: AppSizes.dialogMedium,
              child: Padding(
                  padding: const EdgeInsets.symmetric(vertical: Spacing.lg),
                  child: widget.content!),
            )
          : null,
      actions: [
        SizedBox(
          width: 100,
          child: Button(
            text: widget.actionText,
            loading: _submitState == RequestState.loading,
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
