import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/sizes.dart';

abstract class ButtonBase extends StatelessWidget {
  final String text;
  final ButtonSize size;
  final bool loading;
  final bool disabled;
  final VoidCallback onClick;

  const ButtonBase(
      {super.key,
      this.text = "",
      this.loading = false,
      this.disabled = false,
      required this.onClick,
      this.size = ButtonSize.md});
}
