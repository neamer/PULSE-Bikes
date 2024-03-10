import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class ErrorState extends StatelessWidget {
  final VoidCallback onRetry;

  const ErrorState({super.key, required this.onRetry});

  @override
  Widget build(BuildContext context) {
    return Center(
      child: SpacedColumn(
        spacing: Spacing.lg,
        children: [
          const Text("An error occurred!"),
          Button(text: "Reload", onClick: onRetry)
        ],
      ),
    );
  }
}
