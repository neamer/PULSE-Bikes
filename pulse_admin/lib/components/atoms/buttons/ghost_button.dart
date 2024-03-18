import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button_base.dart';
import 'package:pulse_admin/core/style/colors.dart';

class GhostButton extends ButtonBase {
  const GhostButton({
    Key? key,
    String text = "",
    bool loading = false,
    bool disabled = false,
    required VoidCallback onClick,
    Color color = ColorTheme.n500,
  }) : super(
          key: key,
          text: text,
          loading: loading,
          disabled: disabled,
          onClick: onClick,
          color: color,
        );

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return OutlinedButton(
      style: ButtonStyle(
        backgroundColor: MaterialStateProperty.all<Color>(Colors.transparent),
        side: MaterialStateProperty.all<BorderSide>(
          BorderSide(color: super.color), // Border color
        ),
        padding: MaterialStateProperty.all(
          const EdgeInsets.symmetric(vertical: 18, horizontal: 15),
        ),
      ),
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
          : Text(text!, style: themeData.textTheme.titleSmall),
    );
  }
}
