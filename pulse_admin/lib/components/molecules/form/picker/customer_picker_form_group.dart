import 'package:flutter/material.dart';
import 'package:pulse_admin/components/molecules/form/named_picker_form_field_group.dart';
import 'package:pulse_admin/core/types/delegate.dart';
import 'package:pulse_admin/data/user/customer.dart';
import 'package:pulse_admin/pages/customer/customer_picker_page.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class CustomerPickerFormGroup extends StatelessWidget {
  final String name;
  final String hint;
  final bool enabled;
  final bool clearable;
  final String label;
  final Customer? initialValue;
  final String? Function(Customer?)? validator;

  const CustomerPickerFormGroup({
    Key? key,
    this.hint = '',
    this.enabled = true,
    this.clearable = false,
    this.label = 'Customer',
    required this.name,
    this.initialValue,
    this.validator,
  }) : super(key: key);

  void openPicker<T>(BuildContext context, Delegate<T> onPick) {
    openOverlay(
        context,
        CustomerPickerPage(
          onPick: onPick as Delegate<Customer>,
        ));
  }

  @override
  Widget build(BuildContext context) {
    return NamedPickerFormFieldGroup<Customer>(
        initialValue: initialValue,
        validator: validator,
        label: label,
        name: name,
        enabled: enabled,
        openPicker: openPicker);
  }
}
