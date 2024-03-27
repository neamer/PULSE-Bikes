import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/product_category_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/data/product_category/product_category_upsert_request.dart';
import 'package:pulse_admin/providers/http/products/part_category_provider.dart';

class PartCategoryAddPage extends StatefulWidget {
  final Function onSuccess;

  const PartCategoryAddPage({super.key, required this.onSuccess});
  @override
  State<PartCategoryAddPage> createState() => _PartCategoryAddPageState();
}

class _PartCategoryAddPageState extends State<PartCategoryAddPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<PartCategoryProvider>().insert(
          ProductCategoryUpsertRequest.fromFormData(
              _formKey.currentState!.value));

      widget.onSuccess();
      Navigator.of(context).pop();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Add part category",
      form: ProductCategoryForm(
        formKey: _formKey,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully added part category"),
            text: "SUBMIT",
          ),
        )
      ],
    );
  }
}
