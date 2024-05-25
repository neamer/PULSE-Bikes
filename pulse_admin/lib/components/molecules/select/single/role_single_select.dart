import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/staff/staff_provider.dart';
import 'package:pulse_admin/api/types/user/role.dart';
import 'package:pulse_admin/components/molecules/select/single/abstract_single_select.dart';
import 'package:pulse_admin/components/molecules/select/single/generic_single_select.dart';

class RoleSingleSelect extends AbstractSingleSelect<Role> {
  const RoleSingleSelect(
      {super.key,
      required super.width,
      required super.onChanged,
      super.value,
      super.enabled,
      super.clearable,
      super.text = "Role"});

  @override
  State<RoleSingleSelect> createState() => _RoleSingleSelectState();
}

class _RoleSingleSelectState extends State<RoleSingleSelect> {
  @override
  Widget build(BuildContext context) {
    return SizedBox(
        width: widget.width,
        child: SingleSelect<Role>(
          clearable: widget.clearable,
          enabled: widget.enabled,
          onChanged: widget.onChanged,
          value: widget.value,
          text: widget.text,
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
