import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/buttons/expandable_button.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/pages/products/bicycle/bicycle_category_list_page.dart';
import 'package:pulse_admin/pages/products/bicycle/bicycle_list_page.dart';
import 'package:pulse_admin/pages/products/gear/gear_list_page.dart';
import 'package:pulse_admin/pages/products/part/part_list_page.dart';

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
                  color: ColorTheme.m700,
                  text: "Browse",
                  onClick: () => navigate(const BicycleListPage())),
              Button(
                  color: ColorTheme.m700,
                  text: "Categories",
                  onClick: () => navigate(const BicycleCategoryListPage())),
              Button(color: ColorTheme.m700, text: "Sizes", onClick: () {})
            ],
          ),
          ExpandableButton(
            "GEAR",
            children: [
              Button(
                  color: ColorTheme.m700,
                  text: "Browse",
                  onClick: () => navigate(const GearListPage())),
              Button(
                  color: ColorTheme.m700,
                  text: "Categories",
                  onClick: () => navigate(const BicycleCategoryListPage())),
            ],
          ),
          ExpandableButton(
            "PARTS",
            children: [
              Button(
                  color: ColorTheme.m700,
                  text: "Browse",
                  onClick: () => navigate(const PartListPage())),
              Button(
                  color: ColorTheme.m700,
                  text: "Categories",
                  onClick: () => navigate(const BicycleCategoryListPage())),
            ],
          ),
        ],
      ),
    );
  }
}
