import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/api/types/available_size/available_size.dart';
import 'package:pulse_admin/components/organisms/forms/bicycle_size_select_form.dart';
import 'package:pulse_admin/components/templates/edit_dialog.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/domain/types/forms/bicycle_size_select_form_field_names.dart';

class AvailableSizeSelectDialog extends StatefulWidget {
  final List<AvailableSize> options;
  final void Function(AvailableSize) onSuccess;

  const AvailableSizeSelectDialog(
      {super.key, required this.options, required this.onSuccess});

  @override
  State<AvailableSizeSelectDialog> createState() =>
      _AvailableSizeSelectDialogState();
}

class _AvailableSizeSelectDialogState extends State<AvailableSizeSelectDialog> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future selectItem() async {
    if (_formKey.currentState!.saveAndValidate()) {
      widget.onSuccess(_formKey
          .currentState!.value[AvailableSizeSelectFormFieldNames.bicycleSize]);
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return FormDialog(
      actionText: "Select",
      icon: Icons.select_all,
      title: "Select Available Size",
      content: AvailableSizeSelectForm(
        items: widget.options,
        formKey: _formKey,
      ),
      onSubmit: genericRequestHandler(context, selectItem),
    );
  }
}
