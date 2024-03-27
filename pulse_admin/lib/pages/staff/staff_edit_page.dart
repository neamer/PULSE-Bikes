import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/staff_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/data/user/requests/staff_update_request.dart';
import 'package:pulse_admin/data/user/user.dart';
import 'package:pulse_admin/providers/http/staff/staff_provider.dart';

class StaffEditPage extends StatefulWidget {
  final User data;
  final Function onSuccess;

  const StaffEditPage(this.data, {super.key, required this.onSuccess});
  @override
  State<StaffEditPage> createState() => _StaffEditPageState();
}

class _StaffEditPageState extends State<StaffEditPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<StaffProvider>().update(widget.data.id!,
          StaffUpdateRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Update staff",
      form: StaffForm(
        showPasswordFields: false,
        showImmutableFields: false,
        formKey: _formKey,
        initialValues: widget.data,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully updated staff"),
            text: "UPDATE",
          ),
        )
      ],
    );
  }
}
