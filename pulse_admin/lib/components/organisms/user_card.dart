import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/auth/auth_provider.dart';
import 'package:pulse_admin/api/types/user/staff.dart';
import 'package:pulse_admin/components/atoms/user_icon.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/pages/login_page.dart';

class UserCard extends StatefulWidget {
  const UserCard({super.key});

  @override
  State<UserCard> createState() => _UserCardState();
}

class _UserCardState extends State<UserCard> {
  Staff? _data;

  @override
  void initState() {
    super.initState();

    _data = context.read<AuthProvider>().user;
  }

  void logout() {
    context.read<AuthProvider>().logout();
    Navigator.pushReplacementNamed(context, LoginPage.route);
  }

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return Padding(
      padding: const EdgeInsets.all(Spacing.md),
      child: ClipRRect(
        borderRadius: BorderRadius.circular(Spacing.xs),
        child: Container(
          color: ColorTheme.m750,
          child: Padding(
            padding: const EdgeInsets.all(Spacing.md),
            child: Row(children: [
              UserIcon(role: _data?.getStaffRole()),
              const SizedBox(
                width: Spacing.md,
              ),
              SpacedColumn(
                crossAxisAlignment: CrossAxisAlignment.start,
                spacing: 1,
                children: [
                  Text(
                    "${_data?.firstName ?? ""} ${_data?.lastName ?? ""}",
                    style: themeData.textTheme.titleSmall,
                  ),
                  Text(
                    _data?.role?.name ?? "",
                    style: themeData.textTheme.bodyMedium
                        ?.copyWith(fontSize: 14, color: ColorTheme.b300),
                  )
                ],
              ),
              const Spacer(
                flex: 2,
              ),
              IconButton(
                  onPressed: logout,
                  icon: const Icon(
                    Icons.logout,
                    color: ColorTheme.n500,
                  ))
            ]),
          ),
        ),
      ),
    );
  }
}
