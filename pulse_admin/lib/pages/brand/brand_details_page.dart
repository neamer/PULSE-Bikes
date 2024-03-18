import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/organisms/forms/brand_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/data/brand/brand.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/data/brand/brand_upsert_request.dart';
import 'package:pulse_admin/providers/http/products/brand_provider.dart';

class BrandDetailsPage extends StatefulWidget {
  final Brand data;
  final Function onSuccess;

  const BrandDetailsPage(this.data, {super.key, required this.onSuccess});
  @override
  State<BrandDetailsPage> createState() => _BrandDetailsPageState();
}

class _BrandDetailsPageState extends State<BrandDetailsPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<BrandProvider>().update(widget.data.id!,
          BrandUpsertRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Brand details",
      form: BrandForm(
        enabled: false,
        formKey: _formKey,
        initialValues: widget.data,
      ),
    );
  }
}
