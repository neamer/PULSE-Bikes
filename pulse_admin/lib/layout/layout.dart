import 'package:flutter/material.dart';
import 'package:pulse_admin/components/pages/product_list_page.dart';
import 'package:pulse_admin/layout/components/side_bar.dart';

class Layout extends StatefulWidget {
  const Layout({super.key});

  @override
  _LayoutState createState() => _LayoutState();
}

class _LayoutState extends State<Layout> {
  final GlobalKey<NavigatorState> _navigatorKey = GlobalKey<NavigatorState>();

  @override
  Widget build(BuildContext context) {
    return Row(
      children: [
        Container(
          constraints: const BoxConstraints(minWidth: 300),
          color: Color.fromARGB(255, 23, 23, 37),
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
                builder: (context) => const ProductListPage(),
              );
            },
          ),
        ),
      ],
    );
  }
}

class PageTwo extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Page Two'),
      ),
      body: const Center(
        child: Text('Page Two Content'),
      ),
    );
  }
}
