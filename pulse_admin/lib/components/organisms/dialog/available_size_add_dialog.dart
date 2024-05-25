import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/available_size_provider.dart';
import 'package:pulse_admin/api/types/available_size/available_size.dart';
import 'package:pulse_admin/api/types/available_size/available_size_insert_request.dart';
import 'package:pulse_admin/components/organisms/forms/available_size_form.dart';
import 'package:pulse_admin/components/templates/edit_dialog.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/domain/types/forms/available_size_form_field_names.dart';

class AvailableSizeAddDialog extends StatefulWidget {
  final void Function(AvailableSize) onSuccess;
  final int productId;

  const AvailableSizeAddDialog(
      {super.key, required this.onSuccess, required this.productId});

  @override
  State<AvailableSizeAddDialog> createState() => _AvailableSizeAddDialogState();
}

class _AvailableSizeAddDialogState extends State<AvailableSizeAddDialog> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      var insert = AvailableSizeInsertRequest.fromFormData(
          widget.productId, _formKey.currentState!.value);
      var res = await context.read<AvailableSizeProvider>().insert(insert);

      res?.bicycleSize =
          _formKey.currentState!.value[AvailableSizeFormFieldNames.bicycleSize];
      widget.onSuccess(res!);
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return FormDialog(
      icon: Icons.add_box,
      title: "Add Available Size",
      content: AvailableSizeForm(formKey: _formKey),
      onSubmit: genericRequestHandler(context, submit),
    );
  }
}
