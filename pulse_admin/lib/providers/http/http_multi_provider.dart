import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/providers/http/auth_provider.dart';
import 'package:pulse_admin/providers/http/products/bicycle_category_provider.dart';
import 'package:pulse_admin/providers/http/products/bicycle_provider.dart';
import 'package:pulse_admin/providers/http/products/brand_provider.dart';
import 'package:pulse_admin/providers/http/products/gear_category_provider.dart';
import 'package:pulse_admin/providers/http/products/gear_provider.dart';
import 'package:pulse_admin/providers/http/products/part_category_provider.dart';
import 'package:pulse_admin/providers/http/products/part_provider.dart';

class HttpMultiProvider extends StatelessWidget {
  final Widget? child;

  const HttpMultiProvider({super.key, this.child});

  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => AuthProvider()),
        ChangeNotifierProvider(create: (_) => BicycleProvider()),
        ChangeNotifierProvider(create: (_) => BicycleCategoryProvider()),
        ChangeNotifierProvider(create: (_) => GearProvider()),
        ChangeNotifierProvider(create: (_) => GearCategoryProvider()),
        ChangeNotifierProvider(create: (_) => PartProvider()),
        ChangeNotifierProvider(create: (_) => PartCategoryProvider()),
        ChangeNotifierProvider(create: (_) => BrandProvider()),
      ],
      child: child,
    );
  }
}
