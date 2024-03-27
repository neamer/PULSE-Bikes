import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/organisms/forms/product_category_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/data/product_category/product_category.dart';
import 'package:pulse_admin/data/product_category/product_category_upsert_request.dart';
import 'package:pulse_admin/providers/http/products/part_category_provider.dart';

class PartCategoryDetailsPage extends StatefulWidget {
  final ProductCategory data;
  final Function onSuccess;

  const PartCategoryDetailsPage(this.data,
      {super.key, required this.onSuccess});
  @override
  State<PartCategoryDetailsPage> createState() =>
      _PartCategoryDetailsPageState();
}

class _PartCategoryDetailsPageState extends State<PartCategoryDetailsPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<PartCategoryProvider>().update(
          widget.data.id!,
          ProductCategoryUpsertRequest.fromFormData(
              _formKey.currentState!.value));

      widget.onSuccess();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Part category details",
      form: ProductCategoryForm(
        enabled: false,
        formKey: _formKey,
        initialValues: widget.data,
      ),
    );
  }
}
