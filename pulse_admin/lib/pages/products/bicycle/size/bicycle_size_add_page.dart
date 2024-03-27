import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/bicycle_size_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/data/bicycle_size/bicycle_size_upsert_request.dart';
import 'package:pulse_admin/providers/http/products/bicycle_size_provider.dart';

class BicycleSizeAddPage extends StatefulWidget {
  final Function onSuccess;

  const BicycleSizeAddPage({super.key, required this.onSuccess});
  @override
  State<BicycleSizeAddPage> createState() => _BicycleSizeAddPageState();
}

class _BicycleSizeAddPageState extends State<BicycleSizeAddPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<BicycleSizeProvider>().insert(
          BicycleSizeUpsertRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
      Navigator.of(context).pop();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Add bicycle size",
      form: BicycleSizeForm(
        formKey: _formKey,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully added bicycle size"),
            text: "SUBMIT",
          ),
        )
      ],
    );
  }
}
