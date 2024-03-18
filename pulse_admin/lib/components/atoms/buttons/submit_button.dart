import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/core/http/request_state.dart';
import 'package:pulse_admin/core/style/colors.dart';

class SubmitButton extends StatefulWidget {
  final String text;
  final Color color;
  final bool disabled;
  final Future Function() onClick;

  const SubmitButton(
      {super.key,
      required this.text,
      this.disabled = false,
      required this.onClick,
      this.color = ColorTheme.m500});

  @override
  State<SubmitButton> createState() => _SubmitButtonState();
}

class _SubmitButtonState extends State<SubmitButton> {
  RequestState _submitState = RequestState.init;

  void submit() async {
    setState(() {
      _submitState = RequestState.loading;
    });

    await widget.onClick();

    setState(() {
      _submitState = RequestState.success;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Button(
      onClick: submit,
      text: widget.text,
      color: widget.color,
      loading: _submitState == RequestState.loading,
      disabled: widget.disabled,
    );
  }
}
