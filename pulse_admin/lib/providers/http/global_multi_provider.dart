import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/providers/http/auth_provider.dart';
import 'package:pulse_admin/providers/http/orders/order_provider.dart';
import 'package:pulse_admin/providers/http/products/bicycle_category_provider.dart';
import 'package:pulse_admin/providers/http/products/bicycle_provider.dart';
import 'package:pulse_admin/providers/http/products/bicycle_size_provider.dart';
import 'package:pulse_admin/providers/http/products/brand_provider.dart';
import 'package:pulse_admin/providers/http/products/gear_category_provider.dart';
import 'package:pulse_admin/providers/http/products/gear_provider.dart';
import 'package:pulse_admin/providers/http/products/part_category_provider.dart';
import 'package:pulse_admin/providers/http/products/part_provider.dart';
import 'package:pulse_admin/providers/http/servicing/servicing_provider.dart';
import 'package:pulse_admin/providers/http/staff/staff_provider.dart';

class GlobalMultiProvider extends StatelessWidget {
  final Widget? child;

  const GlobalMultiProvider({super.key, this.child});

  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => AuthProvider()),
        ChangeNotifierProvider(create: (_) => BicycleProvider()),
        ChangeNotifierProvider(create: (_) => BicycleCategoryProvider()),
        ChangeNotifierProvider(create: (_) => BicycleSizeProvider()),
        ChangeNotifierProvider(create: (_) => GearProvider()),
        ChangeNotifierProvider(create: (_) => GearCategoryProvider()),
        ChangeNotifierProvider(create: (_) => PartProvider()),
        ChangeNotifierProvider(create: (_) => PartCategoryProvider()),
        ChangeNotifierProvider(create: (_) => BrandProvider()),
        ChangeNotifierProvider(create: (_) => OrderProvider()),
        ChangeNotifierProvider(create: (_) => ServicingProvider()),
        ChangeNotifierProvider(create: (_) => StaffProvider()),
      ],
      child: child,
    );
  }
}
