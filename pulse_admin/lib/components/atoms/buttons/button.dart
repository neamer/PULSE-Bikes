import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button_base.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class Button extends ButtonBase {
  const Button(
      {super.key,
      super.text,
      super.loading = false,
      super.disabled = false,
      required super.onClick,
      super.color = ColorTheme.m500});

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return TextButton(
        style: ButtonStyle(
            backgroundColor: MaterialStateProperty.all<Color>(super.color),
            shape: MaterialStateProperty.all<RoundedRectangleBorder>(
                RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(Radius.xs),
                    side: BorderSide.none)),
            padding: MaterialStateProperty.all(
                const EdgeInsets.symmetric(vertical: 18, horizontal: 15))),
        onPressed: disabled || loading ? null : onClick,
        child: loading
            ? const SizedBox(
                height: 20,
                width: 20,
                child: CircularProgressIndicator(
                  color: ColorTheme.n500,
                  strokeWidth: 2.5,
                ),
              )
            : Text(text, style: themeData.textTheme.titleSmall));
  }
}
