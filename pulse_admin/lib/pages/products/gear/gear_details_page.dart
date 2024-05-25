import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/gear/gear.dart';
import 'package:pulse_admin/components/organisms/forms/gear_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class GearDetailsPage extends StatefulWidget {
  final Gear data;

  const GearDetailsPage(this.data, {super.key});
  @override
  State<GearDetailsPage> createState() => _GearDetailsPageState();
}

class _GearDetailsPageState extends State<GearDetailsPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Gear details",
      form: GearForm(
        enabled: false,
        formKey: _formKey,
        initialValues: widget.data,
      ),
    );
  }
}
