import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/staff/staff_provider.dart';
import 'package:pulse_admin/api/types/user/requests/staff_insert_request.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/staff_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class StaffAddPage extends StatefulWidget {
  final Function onSuccess;

  const StaffAddPage({super.key, required this.onSuccess});
  @override
  State<StaffAddPage> createState() => _StaffAddPageState();
}

class _StaffAddPageState extends State<StaffAddPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<StaffProvider>().insert(
          StaffInsertRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
      Navigator.of(context).pop();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Add Staff",
      form: StaffForm(
        showPasswordFields: true,
        showImmutableFields: true,
        formKey: _formKey,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully added Staff"),
            text: "SUBMIT",
          ),
        )
      ],
    );
  }
}
