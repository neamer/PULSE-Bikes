import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/components/organisms/forms/servicing_part_form.dart';
import 'package:pulse_admin/components/templates/edit_dialog.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/data/servicing/servicing_part.dart';
import 'package:pulse_admin/model/forms/servicing_part_form_field_names.dart';

class ServicingPartEditDialog extends StatefulWidget {
  final ServicingPart initialValues;
  final void Function(ServicingPart) onSuccess;

  const ServicingPartEditDialog(
      {super.key, required this.initialValues, required this.onSuccess});

  @override
  State<ServicingPartEditDialog> createState() =>
      _ServicingPartEditDialogState();
}

class _ServicingPartEditDialogState extends State<ServicingPartEditDialog> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      widget.initialValues.quantity =
          _formKey.currentState!.value[ServicingPartFormFieldNames.quantity];
      widget.onSuccess(widget.initialValues);
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return FormDialog(
      title: "Edit Quantity",
      content: ServicingPartForm(
          formKey: _formKey, initialValue: widget.initialValues.quantity!),
      onSubmit: genericRequestHandler(context, submit),
    );
  }
}
