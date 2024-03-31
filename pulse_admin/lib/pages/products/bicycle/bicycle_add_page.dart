import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/bicycle_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/data/gear/bicycle_upsert_request.dart';
import 'package:pulse_admin/providers/http/products/bicycle_provider.dart';

class BicycleAddPage extends StatefulWidget {
  final Function onSuccess;

  const BicycleAddPage({super.key, required this.onSuccess});
  @override
  State<BicycleAddPage> createState() => _BicycleAddPageState();
}

class _BicycleAddPageState extends State<BicycleAddPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<BicycleProvider>().insert(
          BicycleUpsertRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
      Navigator.of(context).pop();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Add bicycle",
      form: BicycleForm(
        formKey: _formKey,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully added bicycle"),
            text: "SUBMIT",
          ),
        )
      ],
    );
  }
}
