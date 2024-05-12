import 'package:flutter/material.dart';
import 'package:pulse_admin/core/layout/components/side_bar.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/sizes.dart';
import 'package:pulse_admin/pages/products/bicycle/bicycle_list_page.dart';

class Layout extends StatefulWidget {
  static const String route = '/main';

  const Layout({super.key});

  @override
  State<Layout> createState() => _LayoutState();
}

class _LayoutState extends State<Layout> {
  final GlobalKey<NavigatorState> _navigatorKey = GlobalKey<NavigatorState>();

  @override
  Widget build(BuildContext context) {
    return Material(
      child: Row(
        children: [
          Container(
            width: AppSizes.sidebarWidth,
            color: ColorTheme.m800,
            child: SideBar(
              navigatorKey: _navigatorKey,
            ),
          ),
          Expanded(
            child: Navigator(
              key: _navigatorKey,
              onGenerateRoute: (settings) {
                // You can define your route handlers here
                return MaterialPageRoute(
                  builder: (context) => const BicycleListPage(),
                );
              },
            ),
          ),
        ],
      ),
    );
  }
}
