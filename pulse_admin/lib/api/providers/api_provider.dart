import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/auth/auth_provider.dart';
import 'package:pulse_admin/api/providers/customer/customer_provider.dart';
import 'package:pulse_admin/api/providers/orders/order_provider.dart';
import 'package:pulse_admin/api/providers/products/available_size_provider.dart';
import 'package:pulse_admin/api/providers/products/bicycle_category_provider.dart';
import 'package:pulse_admin/api/providers/products/bicycle_provider.dart';
import 'package:pulse_admin/api/providers/products/bicycle_size_provider.dart';
import 'package:pulse_admin/api/providers/products/brand_provider.dart';
import 'package:pulse_admin/api/providers/products/gear_category_provider.dart';
import 'package:pulse_admin/api/providers/products/gear_provider.dart';
import 'package:pulse_admin/api/providers/products/part_category_provider.dart';
import 'package:pulse_admin/api/providers/products/part_provider.dart';
import 'package:pulse_admin/api/providers/products/product_image_provider.dart';
import 'package:pulse_admin/api/providers/servicing/servicing_provider.dart';
import 'package:pulse_admin/api/providers/staff/staff_provider.dart';

class ApiProvider extends StatelessWidget {
  final Widget? child;

  const ApiProvider({super.key, this.child});

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
        ChangeNotifierProvider(create: (_) => ProductImageProvider()),
        ChangeNotifierProvider(create: (_) => AvailableSizeProvider()),
        ChangeNotifierProvider(create: (_) => CustomerProvider()),
      ],
      child: child,
    );
  }
}
