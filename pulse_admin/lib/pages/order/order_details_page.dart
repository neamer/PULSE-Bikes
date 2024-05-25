import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/orders/order_provider.dart';
import 'package:pulse_admin/api/types/orders/order_header.dart';
import 'package:pulse_admin/api/types/payment/payment_insert_request.dart';
import 'package:pulse_admin/components/atoms/buttons/submit_button.dart';
import 'package:pulse_admin/components/organisms/forms/order_form.dart';
import 'package:pulse_admin/components/templates/list_page_overlay.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/core/http/request_handler.dart';

class OrderDetailsPage extends StatefulWidget {
  final OrderHeader data;
  final VoidCallback? refetchList;

  const OrderDetailsPage(this.data, {super.key, this.refetchList});
  @override
  State<OrderDetailsPage> createState() => _OrderDetailsPageState();
}

class _OrderDetailsPageState extends State<OrderDetailsPage> {
  final _formKey = GlobalKey<FormBuilderState>();
  late OrderHeader item;

  @override
  void initState() {
    super.initState();

    item = widget.data;
  }

  Future process() async {
    var res = await context
        .read<OrderProvider>()
        .process(widget.data.id!, PaymentInsertRequest.buildDefault());

    if (res != null) {
      setState(() {
        item.orderNumber = res.orderNumber;
        item.status = OrderStatus.processed.index;
        item.timeProcessed = res.timeProcessed;
      });
      widget.refetchList?.call();
    }
  }

  Future pack() async {
    await context.read<OrderProvider>().pack(widget.data.id!);

    setState(() {
      item.status = OrderStatus.packed.index;
      item.timePacked = DateTime.now();
    });
    widget.refetchList?.call();
  }

  Future ship() async {
    await context.read<OrderProvider>().ship(widget.data.id!);

    setState(() {
      item.status = OrderStatus.shipped.index;
      item.timeShipped = DateTime.now();
    });
    widget.refetchList?.call();
  }

  Future deliver() async {
    await context.read<OrderProvider>().deliver(widget.data.id!);

    setState(() {
      item.status = OrderStatus.delivered.index;
      item.timeDelivered = DateTime.now();
    });
    widget.refetchList?.call();
  }

  List<Widget> getActions() {
    List<Widget> result = [];

    if (item.status == OrderStatus.draft.index) {
      result.add(
          _buildButtton("PROCESS", process, "Successfully processed order"));
    }

    if (item.delivery == true && item.status == OrderStatus.processed.index) {
      result.add(_buildButtton("PACK", pack, "Successfully packed order"));
    }

    if (item.delivery == true && item.status == OrderStatus.packed.index) {
      result.add(_buildButtton("SHIP", ship, "Successfully shipped order"));
    }

    if (item.delivery == true && item.status == OrderStatus.shipped.index) {
      result.add(_buildButtton(
          "DELIVERED", deliver, "Successfully marked order as delivered"));
    }

    return result;
  }

  @override
  Widget build(BuildContext context) {
    return ListPageOverlay(
      title: "Order details",
      form: OrderForm(
        enabled: false,
        formKey: _formKey,
        initialValues: item,
      ),
      actions: getActions(),
    );
  }

  Widget _buildButtton(String text, Future<dynamic> Function() action,
          String? successMessage) =>
      SizedBox(
          width: 200,
          child: SubmitButton(
            onClick: genericRequestHandler(context, action,
                successMessage: successMessage),
            text: text,
          ));
}
