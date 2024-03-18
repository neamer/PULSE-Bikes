import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/brand_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/data/brand/brand.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/data/brand/brand_upsert_request.dart';
import 'package:pulse_admin/providers/http/products/brand_provider.dart';

class BrandEditPage extends StatefulWidget {
  final Brand data;
  final Function onSuccess;

  const BrandEditPage(this.data, {super.key, required this.onSuccess});
  @override
  State<BrandEditPage> createState() => _BrandEditPageState();
}

class _BrandEditPageState extends State<BrandEditPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<BrandProvider>().update(widget.data.id!,
          BrandUpsertRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Update Brand",
      form: BrandForm(
        formKey: _formKey,
        initialValues: widget.data,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully updated Brand"),
            text: "UPDATE",
          ),
        )
      ],
    );
  }
}
