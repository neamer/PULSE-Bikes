import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/generic/shipping_info.dart';
import 'package:pulse_mobile/model/orders/order_header.dart';
import 'package:pulse_mobile/model/orders/order_request.dart';
import 'package:pulse_mobile/providers/orders/order_provider.dart';
import 'package:pulse_mobile/screens/order/details/order_details_screen.dart';
import 'package:pulse_mobile/utils/messages.dart';
import 'package:pulse_mobile/widgets/basic_text_field.dart';
import 'package:pulse_mobile/widgets/global_navigation_drawer.dart';

class CheckoutScreen extends StatefulWidget {
  static String routeName = "/checkoutt";
  final OrderHeader _data;

  const CheckoutScreen(this._data, {super.key});

  @override
  State<CheckoutScreen> createState() => _CheckoutScreenState();
}

enum ViewType { shipping, localPickup }

class _CheckoutScreenState extends State<CheckoutScreen> {
  OrderProvider? _provider;
  bool isSubmitting = false;

  double _subtotal = 0;
  double _shipping = 0;
  double _total = 0;

  final TextEditingController _countryController = TextEditingController();

  final TextEditingController _stateController = TextEditingController();

  final TextEditingController _cityController = TextEditingController();

  final TextEditingController _streetController = TextEditingController();

  final TextEditingController _zipCodeController = TextEditingController();

  ViewType _viewType = ViewType.shipping;

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return Scaffold(
        drawer: const SafeArea(child: Drawer(child: GlobalNavigationDrawer())),
        appBar: AppBar(
          title: Image.asset(
            "assets/images/logo.png",
            fit: BoxFit.contain,
            height: 50,
          ),
          toolbarHeight: 75,
          centerTitle: true,
          shape: const Border(bottom: BorderSide(color: Colors.cyan, width: 1)),
        ),
        body: SingleChildScrollView(
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 30),
            child:
                Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
              Text(
                "CHECKOUT",
                style: Theme.of(context).textTheme.titleLarge,
              ),
              const SizedBox(
                height: 10,
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Expanded(
                    child: Container(
                      decoration: BoxDecoration(
                          border: Border(
                        bottom: BorderSide(
                            color: _viewType == ViewType.shipping
                                ? themeData.primaryColor
                                : Colors.white24,
                            width: 4),
                      )),
                      child: TextButton(
                        child: const Text("Shipping"),
                        onPressed: () {
                          setState(() {
                            _viewType = ViewType.shipping;
                          });
                        },
                      ),
                    ),
                  ),
                  Expanded(
                    child: Container(
                      decoration: BoxDecoration(
                          border: Border(
                        bottom: BorderSide(
                            color: _viewType == ViewType.localPickup
                                ? themeData.primaryColor
                                : Colors.white24,
                            width: 4),
                      )),
                      child: TextButton(
                        child: const Text("Local Pickup"),
                        onPressed: () {
                          setState(() {
                            _viewType = ViewType.localPickup;
                          });
                        },
                      ),
                    ),
                  ),
                ],
              ),
              Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  if (_viewType == ViewType.shipping)
                    Padding(
                      padding: const EdgeInsets.symmetric(horizontal: 15.0),
                      child: Column(
                        children: [
                          BasicTextField(
                            name: "Country",
                            controller: _countryController,
                            enabled: !isSubmitting,
                          ),
                          BasicTextField(
                            name: "State",
                            controller: _stateController,
                            enabled: !isSubmitting,
                          ),
                          BasicTextField(
                            name: "City",
                            controller: _cityController,
                            enabled: !isSubmitting,
                          ),
                          BasicTextField(
                            name: "Street Address",
                            controller: _streetController,
                            enabled: !isSubmitting,
                          ),
                          BasicTextField(
                            name: "Zip Code",
                            controller: _zipCodeController,
                            enabled: !isSubmitting,
                          ),
                        ],
                      ),
                    ),
                  const SizedBox(
                    height: 15,
                  ),
                  Padding(
                    padding: const EdgeInsets.only(
                        left: 25, right: 25, top: 15, bottom: 30),
                    child: Column(
                      children: [
                        if (_viewType == ViewType.shipping)
                          Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            children: [
                              Text("Subtotal",
                                  style: Theme.of(context)
                                      .textTheme
                                      .bodyLarge
                                      ?.copyWith(fontSize: 14)),
                              Text(_subtotal.toString(),
                                  style: Theme.of(context)
                                      .textTheme
                                      .displayMedium
                                      ?.copyWith(fontSize: 14))
                            ],
                          ),
                        if (_viewType == ViewType.shipping)
                          const SizedBox(
                            height: 6,
                          ),
                        if (_viewType == ViewType.shipping)
                          Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            children: [
                              Text("Shipping",
                                  style: Theme.of(context)
                                      .textTheme
                                      .bodyLarge
                                      ?.copyWith(fontSize: 14)),
                              Text(
                                  _shipping == 0
                                      ? "Free"
                                      : _shipping.toString(),
                                  style: Theme.of(context)
                                      .textTheme
                                      .displayMedium
                                      ?.copyWith(fontSize: 14))
                            ],
                          ),
                        if (_viewType == ViewType.shipping)
                          const SizedBox(
                            height: 6,
                          ),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Text("Total",
                                style: Theme.of(context)
                                    .textTheme
                                    .bodyLarge
                                    ?.copyWith(fontSize: 14)),
                            Text(_total.toString(),
                                style: Theme.of(context)
                                    .textTheme
                                    .displayMedium
                                    ?.copyWith(fontSize: 14))
                          ],
                        ),
                      ],
                    ),
                  ),
                  SizedBox(
                    width: double.infinity,
                    child: OutlinedButton(
                        style: ButtonStyle(
                            backgroundColor:
                                MaterialStateProperty.all<Color>(Colors.white),
                            padding: MaterialStateProperty.all(
                                const EdgeInsets.symmetric(
                                    vertical: 20, horizontal: 30))),
                        onPressed: () => process(context),
                        child: isSubmitting
                            ? SizedBox(
                                height: 21,
                                width: 21,
                                child: CircularProgressIndicator(
                                  color: themeData.colorScheme.background,
                                ),
                              )
                            : Text("Pay with PayPal",
                                style: themeData.textTheme.titleLarge?.copyWith(
                                    color: themeData.colorScheme.background,
                                    fontSize: 18))),
                  ),
                ],
              )
            ]),
          ),
        ));
  }

  @override
  void initState() {
    super.initState();

    _provider = context.read<OrderProvider>();

    calculateCosts();
  }

  void calculateCosts() {
    setState(() {
      _subtotal = (widget._data.orderDetails
          .map((e) => (e.unitPrice ?? 0 * (e.quantity ?? 0)))
          .reduce((a, b) => a + b)) as double;
      _shipping = _subtotal > 100 ? 0 : 10;
      _total = _subtotal + _shipping;
    });
  }

void openDetails(BuildContext context, int? orderId) {
    orderId != null
        ? Navigator.of(context).push(MaterialPageRoute<dynamic>(
            builder: (BuildContext context) {
              return OrderDetailsScreen(orderId);
            },
          ))
        : null;
  }

  void process(BuildContext context) async {
    setState(() {
      isSubmitting = true;
    });

    try {
      ShippingInfo? shippingInfo;

      if(_viewType == ViewType.shipping) {
        shippingInfo = ShippingInfo.build(
          country: _countryController.text,
          state: _stateController.text,
          city: _cityController.text,
          street: _streetController.text,
          zipCode: _zipCodeController.text
        );
      }

      var request = OrderRequest.build(shippingInfo: shippingInfo);
      var response = await _provider?.process(request);
      Messages.errorMessage(context, "Your order was processed succesfully!");

      openDetails(context, response?.id);
      // TODO: Redirect to order details
    } catch (ex) {
      Messages.errorMessage(context, "Error while processing order!");
    } finally {
      setState(() {
        isSubmitting = false;
      });
    }
  }
}
