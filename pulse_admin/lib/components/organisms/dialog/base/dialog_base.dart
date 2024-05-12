import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class DialogBase extends StatelessWidget {
  final String title;
  final Widget? content;
  final List<Widget>? actions;
  final IconData? icon;

  const DialogBase(
      {super.key, required this.title, this.content, this.actions, this.icon});

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);
    return AlertDialog(
      elevation: 0,
      shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.circular(Radius.xs),
          side: BorderSide.none),
      backgroundColor: ColorTheme.m750,
      actionsPadding: const EdgeInsets.only(bottom: Spacing.xl),
      icon: Icon(
        icon,
        color: ColorTheme.n500,
      ),
      title: Text(
        title,
        style: themeData.textTheme.titleSmall
            ?.copyWith(color: Colors.white, fontSize: 18),
      ),
      content: content,
      actionsAlignment: MainAxisAlignment.center,
      actions: actions,
    );
  }
}
