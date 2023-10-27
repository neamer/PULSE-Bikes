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
                  child: Column(children: [
                    Text(
                      "SHOPPING CART",
                      style: Theme.of(context).textTheme.titleLarge,
                    ),
                    const SizedBox(
                      height: 30,
                    ),
                    ListView.builder(
                      shrinkWrap: true,
                      physics: const ScrollPhysics(),
                      itemCount: _data?.orderDetails.length,
                      itemBuilder: (ctx, index) =>
                          CartItem(_data!.orderDetails[index]),
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
}
