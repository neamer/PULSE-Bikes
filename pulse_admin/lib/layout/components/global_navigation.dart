import 'package:flutter/material.dart';
import 'package:pulse_admin/components/pages/bicycle/bicycle_list_page.dart';
import 'package:pulse_admin/layout/layout.dart';

class GlobalNavigation extends StatelessWidget {
  final GlobalKey<NavigatorState> navigatorKey;

  const GlobalNavigation({Key? key, required this.navigatorKey})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        InkWell(
          onTap: () {
            navigatorKey.currentState!.pushReplacement(MaterialPageRoute(
                builder: (context) => const BicycleListPage()));
          },
          child: const Padding(
            padding: EdgeInsets.all(8.0),
            child: Text('Product Search'),
          ),
        ),
        InkWell(
          onTap: () {
            navigatorKey.currentState!.pushReplacement(
                MaterialPageRoute(builder: (context) => PageTwo()));
          },
          child: const Padding(
            padding: EdgeInsets.all(8.0),
            child: Text('Page Two'),
          ),
        ),
        // Add more InkWell widgets for other pages...
      ],
    );
  }
}
