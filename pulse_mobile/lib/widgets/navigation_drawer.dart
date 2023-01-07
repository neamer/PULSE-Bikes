import 'package:flutter/material.dart';
import 'package:pulse_mobile/pages/product_search_screen.dart';

class NavigationDrawer extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return Container(
      padding: EdgeInsets.only(top: 70, left: 30, right: 30),
      color: themeData.backgroundColor,
      child: Column(children: [
        FittedBox(
          child: Image.asset(
            "assets/images/logo.png",
            fit: BoxFit.fill,
          ),
        ),
        SizedBox(
          height: 40,
        ),
        InkWell(
          onTap: () {
            Navigator.of(context)
                .pushNamed("${ProductSearchScreen.routeName}/bikes");
          },
          child: Row(
            children: [
              Icon(
                Icons.directions_bike,
                color: themeData.colorScheme.primary,
              ),
              SizedBox(
                width: 10,
              ),
              Text("BIKES",
                  style: themeData.textTheme.bodyText1?.copyWith(fontSize: 23))
            ],
          ),
        ),
        SizedBox(
          height: 20,
        ),
        InkWell(
          onTap: () {
            Navigator.of(context)
                .pushNamed("${ProductSearchScreen.routeName}/gear");
          },
          child: Row(
            children: [
              Icon(
                Icons.settings,
                color: themeData.colorScheme.primary,
              ),
              SizedBox(
                width: 10,
              ),
              Text("GEAR",
                  style: themeData.textTheme.bodyText1?.copyWith(fontSize: 23))
            ],
          ),
        ),
        SizedBox(
          height: 20,
        ),
        InkWell(
          onTap: () {
            Navigator.of(context)
                .pushNamed("${ProductSearchScreen.routeName}/parts");
          },
          child: Row(
            children: [
              Icon(
                Icons.handyman_outlined,
                color: themeData.colorScheme.primary,
              ),
              SizedBox(
                width: 10,
              ),
              Text("PARTS",
                  style: themeData.textTheme.bodyText1?.copyWith(fontSize: 23))
            ],
          ),
        ),
      ]),
    );
  }
}
