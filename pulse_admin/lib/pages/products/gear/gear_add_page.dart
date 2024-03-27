import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/gear_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/data/gear/gear_upsert_request.dart';
import 'package:pulse_admin/providers/http/products/gear_provider.dart';

class GearAddPage extends StatefulWidget {
  final Function onSuccess;

  const GearAddPage({super.key, required this.onSuccess});
  @override
  State<GearAddPage> createState() => _GearAddPageState();
}

class _GearAddPageState extends State<GearAddPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context
          .read<GearProvider>()
          .insert(GearUpsertRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
      Navigator.of(context).pop();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Add gear",
      form: GearForm(
        formKey: _formKey,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully added gear"),
            text: "SUBMIT",
          ),
        )
      ],
    );
  }
}
