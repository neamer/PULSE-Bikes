import 'package:flutter/material.dart';
import 'package:pulse_admin/layout/components/global_navigation.dart';

class SideBar extends StatelessWidget {
  final GlobalKey<NavigatorState> navigatorKey;

  const SideBar({Key? key, required this.navigatorKey}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.center,
      children: [
        const SizedBox(
          height: 30,
        ),
        SizedBox(
          height: 90,
          width: 160,
          child: SizedBox.expand(
            child: FittedBox(
              child: Image.asset(
                "assets/images/logo.png",
                fit: BoxFit.fill,
              ),
            ),
          ),
        ),
        const SizedBox(
          height: 60,
        ),
        GlobalNavigation(
          navigatorKey: navigatorKey,
        ),
      ],
    );
  }
}
