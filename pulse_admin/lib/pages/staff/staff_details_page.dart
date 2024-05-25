import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/user/staff.dart';
import 'package:pulse_admin/components/organisms/forms/staff_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class StaffDetailsPage extends StatefulWidget {
  final Staff data;

  const StaffDetailsPage(this.data, {super.key});
  @override
  State<StaffDetailsPage> createState() => _StaffDetailsPageState();
}

class _StaffDetailsPageState extends State<StaffDetailsPage> {
  final _formKey = GlobalKey<FormBuilderState>();

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Staff details",
      form: StaffForm(
        enabled: false,
        formKey: _formKey,
        initialValues: widget.data,
      ),
    );
  }
}
