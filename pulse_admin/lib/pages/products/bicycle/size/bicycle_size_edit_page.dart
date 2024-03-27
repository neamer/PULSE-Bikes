import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/bicycle_size_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/data/bicycle_size/bicycle_size.dart';
import 'package:pulse_admin/data/bicycle_size/bicycle_size_upsert_request.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/providers/http/products/bicycle_size_provider.dart';

class BicycleSizeEditPage extends StatefulWidget {
  final BicycleSize data;
  final Function onSuccess;

  const BicycleSizeEditPage(this.data, {super.key, required this.onSuccess});
  @override
  State<BicycleSizeEditPage> createState() => _BicycleSizeEditPageState();
}

class _BicycleSizeEditPageState extends State<BicycleSizeEditPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<BicycleSizeProvider>().update(widget.data.id!,
          BicycleSizeUpsertRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Update bicycle size",
      form: BicycleSizeForm(
        formKey: _formKey,
        initialValues: widget.data,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully updated bicycle size"),
            text: "UPDATE",
          ),
        )
      ],
    );
  }
}
