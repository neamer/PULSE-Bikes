import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/bicycle/bicycle.dart';
import 'package:pulse_mobile/model/gear/gear.dart';
import 'package:pulse_mobile/model/part/part.dart';
import 'package:pulse_mobile/model/product/product.dart';
import 'package:pulse_mobile/pages/product_search_screen.dart';
import 'package:pulse_mobile/providers/gear_provider.dart';
import 'package:pulse_mobile/providers/part_provider.dart';

import 'providers/bicycle_provider.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => BicycleProvider()),
        ChangeNotifierProvider(create: (_) => GearProvider()),
        ChangeNotifierProvider(create: (_) => PartProvider()),
      ],
      child: MaterialApp(
        title: 'PULSE Bikes',
        theme: ThemeData(
            //backgroundColor: Color.fromRGBO(39, 39, 49, 1),
            primaryColor: Color.fromRGBO(188, 188, 188, 1),
            backgroundColor: Color.fromRGBO(19, 19, 29, 1),
            scaffoldBackgroundColor: Color.fromRGBO(19, 19, 29, 1),
            textTheme: ThemeData.light().textTheme.copyWith(
                headline6: TextStyle(
                    fontSize: 24,
                    fontWeight: FontWeight.bold,
                    color: Colors.white),
                headline2: TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.bold,
                    color: Colors.white),
                bodyText1: TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.w300,
                    color: Color.fromRGBO(188, 188, 188, 1))),
            colorScheme: ColorScheme.fromSwatch().copyWith(
                primary: Colors.white,
                secondary: Colors.cyan,
                background: Color.fromRGBO(19, 19, 29, 1)),
            appBarTheme: AppBarTheme(
                backgroundColor: Color.fromRGBO(19, 19, 29, 1),
                foregroundColor: Colors.white)),
        initialRoute: "${ProductSearchScreen.routeName}/bikes",
        routes: {
          "${ProductSearchScreen.routeName}/bikes": (context) =>
              ProductSearchScreen<Bicycle, BicycleProvider>(),
          "${ProductSearchScreen.routeName}/gear": (context) =>
              ProductSearchScreen<Gear, GearProvider>(),
          "${ProductSearchScreen.routeName}/parts": (context) =>
              ProductSearchScreen<Part, PartProvider>(),
        },
      ),
    );
  }
}
