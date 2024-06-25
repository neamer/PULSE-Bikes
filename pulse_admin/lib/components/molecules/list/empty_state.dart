import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class EmptyState extends StatelessWidget {
  final VoidCallback onRetry;

  const EmptyState({super.key, required this.onRetry});

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 100),
      child: SizedBox(
        width: double.infinity,
        child: SpacedColumn(
          spacing: Spacing.lg,
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            const Icon(
              Icons.sentiment_very_dissatisfied,
              size: 50,
              color: ColorTheme.n500,
            ),
            const Text("No results found"),
            Text(
              "Please adjust your filters or add new items",
              style: Theme.of(context)
                  .textTheme
                  .bodyMedium
                  ?.copyWith(color: ColorTheme.n500),
            ),
            const SizedBox(),
            Button(text: "Reload", onClick: onRetry)
          ],
        ),
      ),
    );
  }
}
