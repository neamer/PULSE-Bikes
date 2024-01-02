import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/orders/order_header.dart';
import 'package:pulse_mobile/providers/orders/order_provider.dart';
import 'package:pulse_mobile/screens/order/details/order_details_screen.dart';
import 'package:pulse_mobile/screens/order/list/components/order_list_item.dart';
import 'package:pulse_mobile/widgets/global_navigation_drawer.dart';

class OrderListScreen extends StatefulWidget {
  static String routeName = "/orders";

  const OrderListScreen({super.key});

  @override
  State<OrderListScreen> createState() => _OrderListScreenState();
}

class _OrderListScreenState extends State<OrderListScreen> {
  bool _loading = true;

  OrderProvider? _provider;
  List<OrderHeader>? _data;

  Future loadData() async {
    var searchObject = {
      "IncludePayment": true,
      "IncludeCustomer": true,
      "IncludeDetails": true,
    };

    var tmpData = await _provider?.get(searchObject);

    if (tmpData != null) {
      setState(() {
        _data = tmpData;
        _loading = false;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);
    var size = MediaQuery.of(context).size;

    /*24 is for notification bar on Android*/
    const double itemHeight = 247;
    final double itemWidth = (size.width - 30) / 2;

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
                          "ORDERS",
                          style: Theme.of(context).textTheme.titleLarge,
                        ),
                        const SizedBox(
                          height: 10,
                        ),
                        _data?.isEmpty ?? false
                            ? const Text("Your cart is empty!")
                            : Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  Text("${_data?.length} items"),
                                  const SizedBox(
                                    height: 15,
                                  ),
                                  ListView.builder(
                                    shrinkWrap: true,
                                    physics: const ScrollPhysics(),
                                    itemCount: _data?.length,
                                    itemBuilder: (ctx, index) =>
                                        OrderListItem(_data![index], () => openDetails(context, _data![index].id)),
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

  void openDetails(BuildContext context, int? orderId) {
    orderId != null
        ? Navigator.of(context).push(MaterialPageRoute<dynamic>(
            builder: (BuildContext context) {
              return OrderDetailsScreen(orderId);
            },
          ))
        : null;
  }
}
