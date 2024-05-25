import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/bicycle_size_provider.dart';
import 'package:pulse_admin/api/types/bicycle_size/bicycle_size.dart';
import 'package:pulse_admin/api/types/bicycle_size/bicycle_size_upsert_request.dart';
import 'package:pulse_admin/components/organisms/forms/bicycle_size_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class BicycleSizeDetailsPage extends StatefulWidget {
  final BicycleSize data;
  final Function onSuccess;

  const BicycleSizeDetailsPage(this.data, {super.key, required this.onSuccess});
  @override
  State<BicycleSizeDetailsPage> createState() => _BicycleSizeDetailsPageState();
}

class _BicycleSizeDetailsPageState extends State<BicycleSizeDetailsPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      await context.read<BicycleSizeProvider>().update(widget.data.id!,
          BicycleSizeUpsertRequest.fromFormData(_formKey.currentState!.value));

      widget.onSuccess();
    }
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Bicycle size details",
      form: BicycleSizeForm(
        enabled: false,
        formKey: _formKey,
        initialValues: widget.data,
      ),
    );
  }
}
