import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/servicing/servicing_provider.dart';
import 'package:pulse_admin/api/types/servicing/requests/servicing_register_request.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/servicing_register_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class ServicingRegisterPage extends StatefulWidget {
  final Function onSuccess;

  const ServicingRegisterPage({super.key, required this.onSuccess});
  @override
  State<ServicingRegisterPage> createState() => _ServicingRegisterPageState();
}

class _ServicingRegisterPageState extends State<ServicingRegisterPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<ServicingProvider>().insert(
          ServicingRegisterRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
      Navigator.of(context).pop();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Register servicing",
      form: ServicingRegisterForm(
        formKey: _formKey,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully registered servicing"),
            text: "REGISTER",
          ),
        )
      ],
    );
  }
}
