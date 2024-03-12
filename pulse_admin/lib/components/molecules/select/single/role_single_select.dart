import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/molecules/select/single/generic_single_select.dart';
import 'package:pulse_admin/core/types/delegate.dart';
import 'package:pulse_admin/data/user/role.dart';
import 'package:pulse_admin/providers/http/staff/staff_provider.dart';

class RoleSingleSelect extends StatefulWidget {
  final double width;
  final Delegate<Role?> onChanged;
  final Role? value;

  const RoleSingleSelect(
      {super.key, required this.width, required this.onChanged, this.value});

  @override
  State<RoleSingleSelect> createState() => _RoleSingleSelectState();
}

class _RoleSingleSelectState extends State<RoleSingleSelect> {
  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: SingleSelect<Role>(
          onChanged: widget.onChanged,
          value: widget.value,
          text: "Role",
          renderOption: ((item) => SizedBox(
                child: Text(
                  item.name.toString(),
                  style: Theme.of(context).textTheme.bodyMedium,
                ),
              )),
          fetch: () => context.read<StaffProvider>().getRoles(),
        ));
  }
}
