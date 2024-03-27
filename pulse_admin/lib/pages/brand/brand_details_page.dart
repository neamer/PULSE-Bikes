import 'package:flutter/material.dart';
import 'package:pulse_admin/components/organisms/forms/brand_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:pulse_admin/data/brand/brand.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class BrandDetailsPage extends StatefulWidget {
  final Brand data;

  const BrandDetailsPage(this.data, {super.key});
  @override
  State<BrandDetailsPage> createState() => _BrandDetailsPageState();
}

class _BrandDetailsPageState extends State<BrandDetailsPage> {
  final _formKey = GlobalKey<FormBuilderState>();

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
