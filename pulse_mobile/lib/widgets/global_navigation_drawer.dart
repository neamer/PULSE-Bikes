import 'package:flutter/material.dart';
import 'package:pulse_mobile/screens/account/account_screen.dart';
import 'package:pulse_mobile/screens/cart/cart_screen.dart';
import 'package:pulse_mobile/screens/order/list/order_list_screen.dart';
import 'package:pulse_mobile/screens/product_search_screen.dart';

class GlobalNavigationDrawer extends StatelessWidget {
  const GlobalNavigationDrawer({super.key});

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return Container(
      padding: const EdgeInsets.only(top: 30, left: 30, right: 30),
      color: themeData.colorScheme.background,
      child: Column(children: [
        FittedBox(
          child: Image.asset(
            "assets/images/logo.png",
            fit: BoxFit.fill,
          ),
        ),
        const SizedBox(
          height: 60,
        ),
        InkWell(
          onTap: () {
            Navigator.of(context)
                .pushNamed("${ProductSearchScreen.routeName}/bikes");
          },
          child: Row(
            children: [
              // Icon(
              //   Icons.directions_bike,
              //   color: themeData.colorScheme.primary,
              // ),
              // const SizedBox(
              //   width: 10,
              // ),
              Text("BIKES",
                  style: themeData.textTheme.bodyLarge?.copyWith(fontSize: 20))
            ],
          ),
        ),
        const SizedBox(
          height: 20,
        ),
        InkWell(
          onTap: () {
            Navigator.of(context)
                .pushNamed("${ProductSearchScreen.routeName}/gear");
          },
          child: Row(
            children: [
              // Icon(
              //   Icons.settings,
              //   color: themeData.colorScheme.primary,
              // ),
              // const SizedBox(
              //   width: 10,
              // ),
              Text("GEAR",
                  style: themeData.textTheme.bodyLarge?.copyWith(fontSize: 20))
            ],
          ),
        ),
        const SizedBox(
          height: 20,
        ),
        InkWell(
          onTap: () {
            Navigator.of(context)
                .pushNamed("${ProductSearchScreen.routeName}/parts");
          },
          child: Row(
            children: [
              // Icon(
              //   Icons.handyman_outlined,
              //   color: themeData.colorScheme.primary,
              // ),
              // const SizedBox(
              //   width: 10,
              // ),
              Text("PARTS",
                  style: themeData.textTheme.bodyLarge?.copyWith(fontSize: 20))
            ],
          ),
        ),
        const SizedBox(
          height: 50,
        ),
        InkWell(
          onTap: () {
            Navigator.of(context).pushNamed(CartScreen.routeName);
          },
          child: Row(
            children: [
              Text("CART",
                  style: themeData.textTheme.bodyLarge?.copyWith(fontSize: 20))
            ],
          ),
        ),
        const SizedBox(
          height: 20,
        ),
        InkWell(
          onTap: () {
            Navigator.of(context).pushNamed(OrderListScreen.routeName);
          },
          child: Row(
            children: [
              Text("ORDERS",
                  style: themeData.textTheme.bodyLarge?.copyWith(fontSize: 20))
            ],
          ),
        ),
        const SizedBox(
          height: 50,
        ),
        InkWell(
          onTap: () {
            Navigator.of(context).pushNamed(AccountScreen.routeName);
          },
          child: Row(
            children: [
              Text("ACCOUNT",
                  style: themeData.textTheme.bodyLarge?.copyWith(fontSize: 20))
            ],
          ),
        ),
      ]),
    );
  }
}
