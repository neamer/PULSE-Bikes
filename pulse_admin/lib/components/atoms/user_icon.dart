import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/user/user.dart';

class UserIcon extends StatelessWidget {
  final UserRole? role;

  const UserIcon({super.key, this.role});

  IconData getIconDate() {
    switch (role) {
      case UserRole.administrator:
        return Icons.security;
      case UserRole.mechanic:
        return Icons.build_outlined;
      case UserRole.storekeeper:
        return Icons.store_mall_directory_outlined;
      default:
        return Icons.shopping_cart_outlined;
    }
  }

  @override
  Widget build(BuildContext context) {
    return ClipRRect(
      borderRadius: BorderRadius.circular(Radius.sm),
      child: Container(
        color: ColorTheme.n500,
        height: 50,
        width: 50,
        child: Center(
            child: Icon(
          getIconDate(),
          size: 30,
        )),
      ),
    );
  }
}
