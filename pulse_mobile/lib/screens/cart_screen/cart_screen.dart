import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/orders/order_header.dart';
import 'package:pulse_mobile/providers/orders/order_provider.dart';
import 'package:pulse_mobile/screens/cart_screen/components/cart_item.dart';
import 'package:pulse_mobile/widgets/global_navigation_drawer.dart';

class CartScreen extends StatefulWidget {
  static String routeName = "/cart";

  const CartScreen({super.key});

  @override
  State<CartScreen> createState() => _CartScreenState();
}

class _CartScreenState extends State<CartScreen> {
  bool _loading = false;

  OrderProvider? _provider;
  OrderHeader? _data;

  

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
                          "SHOPPING CART",
                          style: Theme.of(context).textTheme.titleLarge,
                        ),
                        const SizedBox(
                          height: 10,
                        ),
                        _loading == false && _data?.orderDetails.length == 0
                            ? const Text("Your cart is empty!")
                            : Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  Text("${_data?.orderDetails.length} items"),
                                  const SizedBox(
                                    height: 15,
                                  ),
                                  ListView.builder(
                                    shrinkWrap: true,
                                    physics: const ScrollPhysics(),
                                    itemCount: _data?.orderDetails.length,
                                    itemBuilder: (ctx, index) =>
                                        CartItem(_data!.orderDetails[index], removeItem),
                                  ),
                                  Padding(
                                    padding: const EdgeInsets.only(left: 25, right: 25, top: 15, bottom: 30),
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
                                            Text("10101",
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
                                            Text("Free",
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
                                            Text("10101",
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
                                                MaterialStateProperty.all<
                                                    Color>(Colors.white),
                                            padding: MaterialStateProperty.all(
                                                const EdgeInsets.symmetric(
                                                    vertical: 20,
                                                    horizontal: 30))),
                                        onPressed: () {},
                                        child: Text("PROCEED TO CHECKOUT",
                                            style: themeData
                                                .textTheme.titleLarge
                                                ?.copyWith(
                                                    color: themeData
                                                        .colorScheme.background,
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

    loadData();
  }

  Future loadData() async {
    setState(() {
      _loading = true;
    });
    var tmpData = await _provider?.fetchCart();
    setState(() {
      _data = tmpData;
      _loading = false;
    });
  }

  Future removeItem(int id) async {
    var removedItem = await _provider?.removeCartItem(id);

    if(removedItem != null) {
      loadData();
    }
  }
}
