import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/orders/order_header.dart';
import 'package:pulse_mobile/providers/orders/order_provider.dart';
import 'package:pulse_mobile/screens/cart/components/cart_item.dart';
import 'package:pulse_mobile/screens/order/details/components/order_tracker.dart';
import 'package:pulse_mobile/widgets/basic_text_field.dart';
import 'package:pulse_mobile/widgets/global_navigation_drawer.dart';

class OrderDetailsScreen extends StatefulWidget {
  static String routeName = "/order";
  final int orderId;

  const OrderDetailsScreen(this.orderId, {super.key});

  @override
  State<OrderDetailsScreen> createState() => _OrderDetailsScreenState();
}

class _OrderDetailsScreenState extends State<OrderDetailsScreen> {
  bool _loading = false;

  OrderProvider? _provider;
  OrderHeader? _data;

  final TextEditingController _countryController = TextEditingController();

  final TextEditingController _stateController = TextEditingController();

  final TextEditingController _cityController = TextEditingController();

  final TextEditingController _streetController = TextEditingController();

  final TextEditingController _zipCodeController = TextEditingController();

  double _subtotal = 0;
  double _shipping = 0;
  double _total = 0;

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
        body: _loading
            ? const Center(
                child: Padding(
                padding: EdgeInsets.all(20),
                child: CircularProgressIndicator(),
              ))
            : SingleChildScrollView(
                child: Padding(
                  padding: const EdgeInsets.symmetric(
                      horizontal: 20.0, vertical: 30),
                  child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          _data?.orderNumber ?? "",
                          style: Theme.of(context).textTheme.titleLarge,
                        ),
                        const SizedBox(
                          height: 10,
                        ),
                        _loading == false && _data?.orderDetails.length == 0
                            ? const Text("Order has no items!")
                            : Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  Text("${_data?.orderDetails.length} items"),
                                  const SizedBox(
                                    height: 7,
                                  ),
                                  OrderTracker(_data!),
                                  const SizedBox(
                                    height: 25,
                                  ),
                                  ListView.builder(
                                    shrinkWrap: true,
                                    physics: const ScrollPhysics(),
                                    itemCount: _data?.orderDetails.length,
                                    itemBuilder: (ctx, index) => CartItem(
                                        _data!.orderDetails[index], null),
                                  ),
                                  Padding(
                                    padding: const EdgeInsets.only(
                                        left: 25,
                                        right: 25,
                                        top: 15,
                                        bottom: 30),
                                    child: Column(
                                      children: [
                                        Row(
                                          mainAxisAlignment:
                                              MainAxisAlignment.spaceBetween,
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
                                        const SizedBox(
                                          height: 6,
                                        ),
                                        Row(
                                          mainAxisAlignment:
                                              MainAxisAlignment.spaceBetween,
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
                                        const SizedBox(
                                          height: 6,
                                        ),
                                        Row(
                                          mainAxisAlignment:
                                              MainAxisAlignment.spaceBetween,
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
                                        if (_data?.delivery == true)
                                          Padding(
                                            padding: const EdgeInsets.symmetric(
                                                horizontal: 15.0),
                                            child: Column(
                                              children: [
                                                const SizedBox(
                                                  height: 35,
                                                ),
                                                Text(
                                                  "SHIPPING ADDRESS",
                                                  style: Theme.of(context)
                                                      .textTheme
                                                      .bodyLarge,
                                                ),
                                                BasicTextField(
                                                  name: "Country",
                                                  controller:
                                                      _countryController,
                                                  enabled: false,
                                                ),
                                                BasicTextField(
                                                  name: "State",
                                                  controller: _stateController,
                                                  enabled: false,
                                                ),
                                                BasicTextField(
                                                  name: "City",
                                                  controller: _cityController,
                                                  enabled: false,
                                                ),
                                                BasicTextField(
                                                  name: "Street Address",
                                                  controller: _streetController,
                                                  enabled: false,
                                                ),
                                                BasicTextField(
                                                  name: "Zip Code",
                                                  controller:
                                                      _zipCodeController,
                                                  enabled: false,
                                                ),
                                              ],
                                            ),
                                          ),
                                      ],
                                    ),
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

    loadData();
  }

  Future loadData() async {
    setState(() {
      _loading = true;
    });

    var tmpData = await _provider?.getDetails(widget.orderId);

    setState(() {
      _data = tmpData;
      _loading = false;
      calculateCosts();
    });
  }

  void calculateCosts() {
    if (_data == null ||
        _data!.orderDetails == null ||
        _data!.orderDetails.isEmpty) {
      return;
    }
    setState(() {
      _subtotal = (_data?.orderDetails
              .map((e) => (e.unitPrice ?? 0 * (e.quantity ?? 0)))
              .reduce((a, b) => a + b) ??
          0) as double;
      _shipping = _subtotal > 100 ? 0 : 10;
      _total = _subtotal + _shipping;

      _countryController.text = _data?.shippingInfo?.country ?? "";
      _stateController.text = _data?.shippingInfo?.state ?? "";
      _cityController.text = _data?.shippingInfo?.city ?? "";
      _streetController.text = _data?.shippingInfo?.street ?? "";
      _zipCodeController.text = _data?.shippingInfo?.zipCode ?? "";
    });
  }
}
