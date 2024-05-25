import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/brand_provider.dart';
import 'package:pulse_admin/api/types/brand/brand_upsert_request.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/brand_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class BrandAddPage extends StatefulWidget {
  final Function onSuccess;

  const BrandAddPage({super.key, required this.onSuccess});
  @override
  State<BrandAddPage> createState() => _BrandAddPageState();
}

class _BrandAddPageState extends State<BrandAddPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<BrandProvider>().insert(
          BrandUpsertRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
      Navigator.of(context).pop();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Add Brand",
      form: BrandForm(
        formKey: _formKey,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully added Brand"),
            text: "SUBMIT",
          ),
        )
      ],
    );
  }
}
