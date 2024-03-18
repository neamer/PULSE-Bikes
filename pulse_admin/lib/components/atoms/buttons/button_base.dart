import 'package:flutter/material.dart';

abstract class ButtonBase extends StatelessWidget {
  final String text;
  final Color color;
  final bool loading;
  final bool disabled;
  final VoidCallback onClick;

  const ButtonBase(
      {super.key,
      this.text = "",
      this.loading = false,
      this.disabled = false,
      required this.onClick,
      required this.color});
}
