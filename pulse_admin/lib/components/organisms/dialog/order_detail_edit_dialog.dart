import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/api/types/orders/order_detail.dart';
import 'package:pulse_admin/components/organisms/forms/order_detail_form.dart';
import 'package:pulse_admin/components/templates/edit_dialog.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/domain/types/forms/order_detail_form_fields.dart';

class OrderDetailEditDialog extends StatefulWidget {
  final OrderDetail initialValues;
  final void Function(OrderDetail) onSuccess;

  const OrderDetailEditDialog(
      {super.key, required this.initialValues, required this.onSuccess});

  @override
  State<OrderDetailEditDialog> createState() => _OrderDetailEditDialogState();
}

class _OrderDetailEditDialogState extends State<OrderDetailEditDialog> {
  final _formKey = GlobalKey<FormBuilderState>();

  Future submit() async {
    if (_formKey.currentState!.saveAndValidate()) {
      widget.initialValues.quantity =
          _formKey.currentState!.value[OrderDetailFormFieldNames.quantity];
      widget.onSuccess(widget.initialValues);
    } else {
      throw const ValidationException();
    }
  }

  @override
  Widget build(BuildContext context) {
    return FormDialog(
      title: "Edit Quantity",
      content: OrderDetailForm(
          formKey: _formKey, initialValue: widget.initialValues.quantity!),
      onSubmit: genericRequestHandler(context, submit),
    );
  }
}
