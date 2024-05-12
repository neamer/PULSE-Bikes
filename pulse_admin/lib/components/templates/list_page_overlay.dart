import 'package:flutter/material.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/sizes.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class ListPageOverlay extends StatelessWidget {
  final String title;
  final Widget form;
  final List<Widget>? actions;
  final double actionsSpacing;

  const ListPageOverlay({
    Key? key,
    required this.title,
    required this.form,
    this.actions,
    this.actionsSpacing = Spacing.md,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(title),
        scrolledUnderElevation: 0,
      ),
      body: SingleChildScrollView(
        child: Center(
          child: Padding(
            padding:
                const EdgeInsets.only(top: Spacing.xl, bottom: 4 * Spacing.xxl),
            child: SizedBox(
              width: AppSizes.detailsWidth,
              child: form,
            ),
          ),
        ),
      ),
      floatingActionButton: SpacedRow(
        spacing: actionsSpacing,
        mainAxisAlignment: MainAxisAlignment.center,
        children: actions ?? [],
      ),
    );
  }
}
