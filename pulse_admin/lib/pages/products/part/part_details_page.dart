import 'package:flutter/material.dart';
import 'package:pulse_admin/components/organisms/forms/part_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/data/part/part.dart';

class PartDetailsPage extends StatefulWidget {
  final Part data;

  const PartDetailsPage(this.data, {super.key});
  @override
  State<PartDetailsPage> createState() => _PartDetailsPageState();
}

class _PartDetailsPageState extends State<PartDetailsPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Part details",
      form: PartForm(
        enabled: false,
        formKey: _formKey,
        initialValues: widget.data,
      ),
    );
  }
}
