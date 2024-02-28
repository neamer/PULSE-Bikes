import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button_base.dart';

class Button extends ButtonBase {
  const Button(
      {super.key,
      super.text,
      super.loading = false,
      super.disabled = false,
      required super.onClick});

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return OutlinedButton(
        style: ButtonStyle(
            backgroundColor: MaterialStateProperty.all<Color>(
                const Color.fromRGBO(35, 35, 51, 1)),
            padding: MaterialStateProperty.all(
                const EdgeInsets.symmetric(vertical: 7, horizontal: 15))),
        onPressed: disabled ? null : onClick,
        child: loading
            ? SizedBox(
                height: 20,
                width: 20,
                child: CircularProgressIndicator(
                  color: themeData.colorScheme.background,
                ),
              )
            : Text(text, style: themeData.textTheme.titleSmall));
  }
}
