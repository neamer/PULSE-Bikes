import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/bicycle/bicycle.dart';
import 'package:pulse_mobile/model/gear/gear.dart';
import 'package:pulse_mobile/model/part/part.dart';
import 'package:pulse_mobile/pages/landing_screen/landing_screen.dart';
import 'package:pulse_mobile/pages/product_search_screen.dart';
import 'package:pulse_mobile/providers/bicycle_size_provider.dart';
import 'package:pulse_mobile/providers/brand_provider.dart';
import 'package:pulse_mobile/providers/category_provider.dart';
import 'package:pulse_mobile/providers/gear_provider.dart';
import 'package:pulse_mobile/providers/part_provider.dart';

import 'providers/bicycle_provider.dart';
import 'providers/user_provider.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => UserProvider()),
        ChangeNotifierProvider(create: (_) => BicycleProvider()),
        ChangeNotifierProvider(create: (_) => GearProvider()),
        ChangeNotifierProvider(create: (_) => PartProvider()),
        ChangeNotifierProvider(create: (_) => BrandProvider()),
        ChangeNotifierProvider(
            create: (_) => ProductCategoryProvider<Bicycle>()),
        ChangeNotifierProvider(create: (_) => ProductCategoryProvider<Part>()),
        ChangeNotifierProvider(create: (_) => ProductCategoryProvider<Gear>()),
        ChangeNotifierProvider(create: (_) => BicycleSizeProvider()),
      ],
      child: MaterialApp(
        title: 'PULSE Bikes',
        theme: ThemeData(
            //backgroundColor: Color.fromRGBO(39, 39, 49, 1),
            primaryColor: const Color.fromRGBO(188, 188, 188, 1),
            scaffoldBackgroundColor: const Color.fromRGBO(19, 19, 29, 1),
            buttonTheme: ThemeData.light().buttonTheme.copyWith(),
            textTheme: ThemeData.light().textTheme.copyWith(
                titleLarge: const TextStyle(
                    fontSize: 24,
                    fontWeight: FontWeight.bold,
                    color: Colors.white),
                displayMedium: const TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.bold,
                    color: Colors.white),
                bodyLarge: const TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.w300,
                    color: Color.fromRGBO(188, 188, 188, 1)),
                bodyMedium: const TextStyle(
                    fontSize: 16,
                    fontWeight: FontWeight.w300,
                    color: Color.fromRGBO(188, 188, 188, 1))),
            appBarTheme: const AppBarTheme(
                backgroundColor: Color.fromRGBO(19, 19, 29, 1),
                foregroundColor: Colors.white),
            colorScheme: ColorScheme.fromSwatch()
                .copyWith(
                    primary: Colors.white,
                    secondary: Colors.cyan,
                    background: const Color.fromRGBO(19, 19, 29, 1),
                    outline: const Color.fromRGBO(43, 43, 62, 1))
                .copyWith(background: const Color.fromRGBO(19, 19, 29, 1))),
        initialRoute: LandingScreen.routeName,
        routes: {
          LandingScreen.routeName: (context) => const LandingScreen(),
          "${ProductSearchScreen.routeName}/bikes": (context) =>
              const ProductSearchScreen<Bicycle, BicycleProvider>(),
          "${ProductSearchScreen.routeName}/gear": (context) =>
              const ProductSearchScreen<Gear, GearProvider>(),
          "${ProductSearchScreen.routeName}/parts": (context) =>
              const ProductSearchScreen<Part, PartProvider>(),
        },
      ),
    );
  }
}
