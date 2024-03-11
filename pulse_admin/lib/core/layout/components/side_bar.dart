import 'package:flutter/material.dart';
import 'package:pulse_admin/components/organisms/user_card.dart';
import 'package:pulse_admin/core/layout/components/global_navigation.dart';

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
          height: 60,
          width: 100,
          child: FittedBox(
            child: Image.asset(
              "assets/images/logo.png",
              fit: BoxFit.contain,
            ),
          ),
        ),
        const SizedBox(
          height: 25,
        ),
        Expanded(
          child: SingleChildScrollView(
            child: GlobalNavigation(
              navigatorKey: navigatorKey,
            ),
          ),
        ),
        UserCard(),
      ],
    );
  }
}
