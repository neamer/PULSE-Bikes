import 'package:flutter/material.dart';
import 'package:flutter_paypal/flutter_paypal.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/generic/shipping_info.dart';
import 'package:pulse_mobile/model/orders/order_header.dart';
import 'package:pulse_mobile/model/orders/order_request.dart';
import 'package:pulse_mobile/model/payment/payment_insert_request.dart';
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
                              Text(_subtotal.toStringAsFixed(2),
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
                            Text(_total.toStringAsFixed(2),
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
                        onPressed: () => openPaypalCheckout(context),
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

  void openPaypalCheckout(BuildContext context1) async {
    Navigator.of(context1).push(
      MaterialPageRoute(
        builder: (BuildContext context) => UsePaypal(
            sandboxMode: true,
            clientId:
                "AbwRhd401Pt9fQVzIH3RvySt5gDqM5ZleK18FV2Z9yO1D-GbV61FuU9F6vMMqp4SbNWlU6WBGmORbwUb",
            secretKey:
                "EEg0c8ds6xwrySgfY9lwMupUePcAyQcAC8DwiRnUk9FiwfQvlQnmHvhzpJq4Nad3ugrpSk4hGS9grRTt",
            returnURL: "https://samplesite.com/return",
            cancelURL: "https://samplesite.com/cancel",
            transactions: [
              {
                "amount": {
                  "total": _total.toStringAsFixed(2),
                  "currency": "USD",
                  "details": {
                    "subtotal": _subtotal.toStringAsFixed(2),
                    "shipping": _shipping.toStringAsFixed(2),
                    "shipping_discount": _shipping.toStringAsFixed(2)
                  }
                },
                "description": "The payment transaction description.",
                "payment_options": {
                  "allowed_payment_method": "INSTANT_FUNDING_SOURCE"
                },
                "item_list": {
                  "items": widget._data.orderDetails.map((item) => ({
                        "name": item.product?.model ?? "",
                        "quantity": item.quantity,
                        "price": (item.unitPrice ?? 0) * (item.quantity ?? 0),
                        "currency": "USD"
                      })),
                }
              }
            ],
            note: "Contact us for any questions on your order.",
            onSuccess: (Map params) async {
              print("onSuccess: $params");
              var paymentId = params["paymentId"];
              process(context1, paymentId);
            },
            onError: (error) {
              print("onError: $error");
            },
            onCancel: (params) {
              print('cancelled: $params');
            }),
      ),
    );
  }

  void process(BuildContext context, String paymentId) async {
    setState(() {
      isSubmitting = true;
    });

    try {
      ShippingInfo? shippingInfo;

      if (_viewType == ViewType.shipping) {
        shippingInfo = ShippingInfo.build(
            country: _countryController.text,
            state: _stateController.text,
            city: _cityController.text,
            street: _streetController.text,
            zipCode: _zipCodeController.text);
      }

      var request = OrderRequest.build(
          shippingInfo: shippingInfo,
          payment: PaymentInsertRequest.build("PayPal", paymentId));
      var response = await _provider?.process(request);

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
