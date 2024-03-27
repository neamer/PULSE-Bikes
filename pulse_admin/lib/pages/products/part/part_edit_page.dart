import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/part_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/data/part/part.dart';
import 'package:pulse_admin/data/part/part_upsert_request.dart';
import 'package:pulse_admin/providers/http/products/part_provider.dart';

class PartEditPage extends StatefulWidget {
  final Part data;
  final Function onSuccess;

  const PartEditPage(this.data, {super.key, required this.onSuccess});
  @override
  State<PartEditPage> createState() => _PartEditPageState();
}

class _PartEditPageState extends State<PartEditPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<PartProvider>().update(widget.data.id!,
          PartUpsertRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Update part",
      form: PartForm(
        formKey: _formKey,
        initialValues: widget.data,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully updated part"),
            text: "UPDATE",
          ),
        )
      ],
    );
  }
}
