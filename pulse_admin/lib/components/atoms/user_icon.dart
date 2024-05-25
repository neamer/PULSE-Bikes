import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/user/staff.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class UserIcon extends StatelessWidget {
  final StaffRole? role;

  const UserIcon({super.key, this.role});

  IconData getIconDate() {
    switch (role) {
      case StaffRole.administrator:
        return Icons.security;
      case StaffRole.mechanic:
        return Icons.build_outlined;
      case StaffRole.storekeeper:
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
