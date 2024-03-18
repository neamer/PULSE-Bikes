import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/buttons/expandable_button.dart';
import 'package:pulse_admin/components/atoms/buttons/navigation_button.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/pages/brand/brand_list_page.dart';
import 'package:pulse_admin/pages/order/order_list_page.dart';
import 'package:pulse_admin/pages/products/bicycle/bicycle_category_list_page.dart';
import 'package:pulse_admin/pages/products/bicycle/bicycle_list_page.dart';
import 'package:pulse_admin/pages/products/bicycle/bicycle_size_list_page.dart';
import 'package:pulse_admin/pages/products/gear/gear_category_list_page.dart';
import 'package:pulse_admin/pages/products/gear/gear_list_page.dart';
import 'package:pulse_admin/pages/products/part/part_category_list_page.dart';
import 'package:pulse_admin/pages/products/part/part_list_page.dart';
import 'package:pulse_admin/pages/products/staff/staff_list_page.dart';
import 'package:pulse_admin/pages/servicing/servicing_list_page.dart';

class GlobalNavigation extends StatelessWidget {
  final GlobalKey<NavigatorState> navigatorKey;

  const GlobalNavigation({Key? key, required this.navigatorKey})
      : super(key: key);

  void navigate(Widget page) => navigatorKey.currentState!.pushAndRemoveUntil(
      MaterialPageRoute(builder: (context) => page),
      (Route<dynamic> route) => false);

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
              Button(
                  color: ColorTheme.m700,
                  text: "Sizes",
                  onClick: () => navigate(const BicycleSizeListPage()))
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
                  onClick: () => navigate(const GearCategoryListPage())),
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
                  onClick: () => navigate(const PartCategoryListPage())),
            ],
          ),
          NavigationButton(
              onClick: () => navigate(const BrandListPage()), text: "BRANDS"),
          NavigationButton(
              onClick: () => navigate(const OrderListPage()), text: "ORDERS"),
          NavigationButton(
              onClick: () => navigate(const ServicingListPage()),
              text: "SERVICING"),
          NavigationButton(
              onClick: () => navigate(const StaffListPage()), text: "STAFF"),
        ],
      ),
    );
  }
}
