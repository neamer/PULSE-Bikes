import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/bicycle_provider.dart';
import 'package:pulse_admin/api/types/bicycle/bicycle.dart';
import 'package:pulse_admin/api/types/gear/bicycle_upsert_request.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/bicycle_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class BicycleEditPage extends StatefulWidget {
  final Bicycle data;
  final Function onSuccess;

  const BicycleEditPage(this.data, {super.key, required this.onSuccess});
  @override
  State<BicycleEditPage> createState() => _BicycleEditPageState();
}

class _BicycleEditPageState extends State<BicycleEditPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<BicycleProvider>().update(widget.data.id!,
          BicycleUpsertRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Update bicycle",
      form: BicycleForm(
        formKey: _formKey,
        initialValues: widget.data,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully updated bicycle"),
            text: "UPDATE",
          ),
        )
      ],
    );
  }
}
