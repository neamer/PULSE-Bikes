import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/available_size_provider.dart';
import 'package:pulse_admin/api/types/available_size/available_size.dart';
import 'package:pulse_admin/api/types/available_size/available_size_update_request.dart';
import 'package:pulse_admin/components/organisms/forms/available_size_form.dart';
import 'package:pulse_admin/components/templates/edit_dialog.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';

class AvailableSizeEditDialog extends StatefulWidget {
  final AvailableSize initialValues;
  final void Function(AvailableSize) onSuccess;

  const AvailableSizeEditDialog(
      {super.key, required this.initialValues, required this.onSuccess});

  @override
  State<AvailableSizeEditDialog> createState() =>
      _AvailableSizeEditDialogState();
}

class _AvailableSizeEditDialogState extends State<AvailableSizeEditDialog> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      var res = await context.read<AvailableSizeProvider>().update(
          widget.initialValues.id!,
          AvailableSizeUpdateRequest.fromFormData(
              _formKey.currentState!.value));

      widget.onSuccess(res!);
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return FormDialog(
      title: "Edit Available Size",
      content: AvailableSizeForm(
          enableBicycleSize: false,
          formKey: _formKey,
          initialValues: widget.initialValues),
      onSubmit: genericRequestHandler(context, submit),
    );
  }
}
