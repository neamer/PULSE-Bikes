import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button_base.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class NavigationButton extends ButtonBase {
  const NavigationButton(
      {super.key,
      super.text,
      super.loading = false,
      super.disabled = false,
      required super.onClick,
      super.color = ColorTheme.m750});

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return ClipRRect(
        borderRadius: BorderRadius.circular(Radius.xs),
        child: SizedBox(
          width: double.infinity,
          child: OutlinedButton(
              style: ButtonStyle(
                  overlayColor: MaterialStateProperty.all<Color>(
                      ColorTheme.m600.withAlpha(150)),
                  backgroundColor:
                      MaterialStateProperty.all<Color>(super.color),
                  padding: MaterialStateProperty.all(const EdgeInsets.symmetric(
                      vertical: Spacing.xl + 3, horizontal: Spacing.lg))),
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
                  : Align(
                      alignment: Alignment.centerLeft,
                      child: Text(
                        text,
                        style: themeData.textTheme.titleSmall,
                        textAlign: TextAlign.left,
                      ))),
        ));
  }
}
