import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/providers/http/bicycle_category_provider.dart';
import 'package:pulse_admin/providers/http/bicycle_provider.dart';
import 'package:pulse_admin/providers/http/brand_provider.dart';
import 'package:pulse_admin/providers/http/gear_category_provider.dart';
import 'package:pulse_admin/providers/http/gear_provider.dart';
import 'package:pulse_admin/providers/http/part_category_provider.dart';
import 'package:pulse_admin/providers/http/part_provider.dart';

class GlobalMultiProvider extends StatelessWidget {
  final Widget? child;

  const GlobalMultiProvider({super.key, this.child});

  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      providers: [
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
