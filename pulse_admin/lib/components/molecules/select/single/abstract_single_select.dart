import 'package:flutter/material.dart';
import 'package:pulse_admin/domain/types/delegate.dart';

abstract class AbstractSingleSelect<T> extends StatefulWidget {
  final String text;
  final bool enabled;
  final bool clearable;
  final double width;
  final Delegate<T?> onChanged;
  final T? value;

  const AbstractSingleSelect(
      {super.key,
      required this.width,
      required this.onChanged,
      this.value,
      this.enabled = true,
      this.clearable = true,
      required this.text});
}
