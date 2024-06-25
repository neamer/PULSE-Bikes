import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/servicing/servicing.dart';
import 'package:pulse_mobile/providers/servicing/servicing_provider.dart';
import 'package:pulse_mobile/screens/servicing/list/components/servicing_list_item.dart';
import 'package:pulse_mobile/screens/servicing/detail/servicing_detail_screen.dart';
import 'package:pulse_mobile/widgets/global_navigation_drawer.dart';

class ServicingListScreen extends StatefulWidget {
  static String routeName = "/Servicings";

  const ServicingListScreen({super.key});

  @override
  State<ServicingListScreen> createState() => _ServicingListScreenState();
}

class _ServicingListScreenState extends State<ServicingListScreen> {
  bool _loading = true;

  ServicingProvider? _provider;
  List<Servicing>? _data;

  Future loadData() async {
    var searchObject = {
      // "IncludePayment": true,
      // "IncludeCustomer": true,
      // "IncludeDetails": true,
    };

    var tmpData = await _provider?.fetchServicingHistory();

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
                          "Servicing",
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
                                        ServicingListItem(
                                            _data![index],
                                            () => openDetails(
                                                context, _data![index].id)),
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

    _provider = context.read<ServicingProvider>();

    loadData();
  }

  void openDetails(BuildContext context, int? ServicingId) {
    ServicingId != null
        ? Navigator.of(context).push(MaterialPageRoute<dynamic>(
            builder: (BuildContext context) {
              return ServicingDetailsScreen(ServicingId);
            },
          ))
        : null;
  }
}
