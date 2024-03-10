import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/buttons/expandable_button.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/pages/bicycle/bicycle_category_list_page.dart';
import 'package:pulse_admin/pages/bicycle/bicycle_list_page.dart';
import 'package:pulse_admin/pages/bicycle/gear_list_page.dart';
import 'package:pulse_admin/pages/bicycle/part_list_page.dart';

class GlobalNavigation extends StatelessWidget {
  final GlobalKey<NavigatorState> navigatorKey;

  const GlobalNavigation({Key? key, required this.navigatorKey})
      : super(key: key);

  void navigate(Widget page) => navigatorKey.currentState!
      .pushReplacement(MaterialPageRoute(builder: (context) => page));

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(Spacing.md),
      child: SpacedColumn(
        spacing: Spacing.md,
        children: [
          ExpandableButton(
            "BIKES",
            children: [
              Button(
                  text: "Browse",
                  onClick: () => navigate(const BicycleListPage())),
              Button(
                  text: "Categories",
                  onClick: () => navigate(const BicycleCategoryListPage())),
              Button(text: "Sizes", onClick: () {})
            ],
          ),
          ExpandableButton(
            "GEAR",
            children: [
              Button(
                  text: "Browse",
                  onClick: () => navigate(const GearListPage())),
              Button(
                  text: "Categories",
                  onClick: () => navigate(const BicycleCategoryListPage())),
            ],
          ),
          ExpandableButton(
            "PARTS",
            children: [
              Button(
                  text: "Browse",
                  onClick: () => navigate(const PartListPage())),
              Button(
                  text: "Categories",
                  onClick: () => navigate(const BicycleCategoryListPage())),
            ],
          ),
        ],
      ),
    );
  }
}
