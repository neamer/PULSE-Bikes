import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/ghost_button.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/organisms/forms/servicing_details_form.dart';
import 'package:pulse_admin/components/organisms/forms/servicing_offer_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/core/exceptions/validation_exception.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/payment/payment_insert_request.dart';
import 'package:pulse_admin/data/servicing/requests/servicing_offer_insert_request.dart';
import 'package:pulse_admin/data/servicing/servicing.dart';
import 'package:pulse_admin/data/servicing/servicing_status.dart';
import 'package:pulse_admin/providers/http/servicing/servicing_provider.dart';

class ServicingDetailsPage extends StatefulWidget {
  final Servicing data;
  final Function onSuccess;

  const ServicingDetailsPage(this.data, {super.key, required this.onSuccess});
  @override
  State<ServicingDetailsPage> createState() => _ServicingDetailsPageState();
}

class _ServicingDetailsPageState extends State<ServicingDetailsPage> {
  final _formKey = GlobalKey<FormBuilderState>();
  final _offerFormKey = GlobalKey<FormBuilderState>();

  bool showOfferForm = false;

  Future submitOffer() async {
    if (_offerFormKey.currentState!.saveAndValidate()) {
      await context.read<ServicingProvider>().submitOffer(
          widget.data.id!,
          ServicingOfferInsertRequest.fromFormData(
              _offerFormKey.currentState!.value));

      widget.onSuccess();
      Navigator.of(context).pop();
    } else {
      throw const ValidationException();
    }
  }

  Future registerPayment() async {
    await context
        .read<ServicingProvider>()
        .registerPayment(widget.data.id!, PaymentInsertRequest.buildDefault());

    widget.onSuccess();
    Navigator.of(context).pop();
  }

  Future complete() async {
    await context.read<ServicingProvider>().complete(widget.data.id!);

    widget.onSuccess();
    Navigator.of(context).pop();
  }

  bool calcHasOffer() {
    return widget.data.labourCost != null ||
        (widget.data.offerDetails?.isNotEmpty ?? false) ||
        widget.data.servicingParts.isNotEmpty;
  }

  List<Widget> getActions() {
    List<Widget> result = [];
    bool hasOffer = calcHasOffer();

    if (!showOfferForm && !hasOffer) {
      result.add(_buildButtton("ADD OFFER", () async {
        setState(() {
          showOfferForm = true;
        });
      }));
    }

    if (showOfferForm && !hasOffer) {
      result.add(_buildRequestButton("SUBMIT OFFER", submitOffer,
          "Successfully submitted servicing offer"));
    }

    if (showOfferForm && !hasOffer) {
      result.add(_buildButtton("CANCEL", () async {
        setState(() {
          showOfferForm = false;
        });
      }));
    }

    if (widget.data.status == ServicingStatus.pendingPayment.index) {
      result.add(_buildRequestButton("REGISTER PAYMENT", registerPayment,
          "Successfully submitted servicing offer"));
    }

    if (widget.data.status == ServicingStatus.pendingServicing.index) {
      result.add(_buildRequestButton("MARK COMPLETED", complete,
          "Successfully marked servicing as completed"));
    }

    return result;
  }

  @override
  Widget build(BuildContext context) {
    var hasOffer = calcHasOffer();

    return ListPageOverlay(
      title: "Details servicing",
      form: SpacedColumn(
        spacing: Spacing.xxl,
        children: [
          ServicingDetailsForm(
            initialValues: widget.data,
            enabled: false,
            formKey: _formKey,
          ),
          if (showOfferForm || hasOffer)
            ServicingOfferForm(
              formKey: _offerFormKey,
              initialValues: widget.data,
              enabled: !hasOffer,
            )
        ],
      ),
      actions: getActions(),
    );
  }

  Widget _buildRequestButton(String text, Future<dynamic> Function() action,
          String? successMessage) =>
      SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, action,
                successMessage: successMessage),
            text: text,
          ));

  Widget _buildButtton(
    String text,
    void Function() action,
  ) =>
      SizedBox(
          width: 200,
          child: GhostButton(
            onClick: action,
            text: text,
          ));
}
