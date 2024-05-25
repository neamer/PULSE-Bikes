import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/bicycle/bicycle.dart';
import 'package:pulse_admin/components/organisms/forms/bicycle_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class BicycleDetailsPage extends StatefulWidget {
  final Bicycle data;

  const BicycleDetailsPage(this.data, {super.key});
  @override
  State<BicycleDetailsPage> createState() => _BicycleDetailsPageState();
}

class _BicycleDetailsPageState extends State<BicycleDetailsPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Bicycle details",
      form: BicycleForm(
        enabled: false,
        formKey: _formKey,
        initialValues: widget.data,
      ),
    );
  }
}
