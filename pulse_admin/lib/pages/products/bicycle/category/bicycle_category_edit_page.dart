import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/product_category_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/data/product_category/product_category.dart';
import 'package:pulse_admin/data/product_category/product_category_upsert_request.dart';
import 'package:pulse_admin/providers/http/products/bicycle_category_provider.dart';

class BicycleCategoryEditPage extends StatefulWidget {
  final ProductCategory data;
  final Function onSuccess;

  const BicycleCategoryEditPage(this.data,
      {super.key, required this.onSuccess});
  @override
  State<BicycleCategoryEditPage> createState() =>
      _BicycleCategoryEditPageState();
}

class _BicycleCategoryEditPageState extends State<BicycleCategoryEditPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<BicycleCategoryProvider>().update(
          widget.data.id!,
          ProductCategoryUpsertRequest.fromFormData(
              _formKey.currentState!.value));

      widget.onSuccess();
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Update bicycle category",
      form: ProductCategoryForm(
        formKey: _formKey,
        initialValues: widget.data,
      ),
      actions: [
        SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, submit,
                successMessage: "Successfully updated bicycle category"),
            text: "UPDATE",
          ),
        )
      ],
    );
  }
}
