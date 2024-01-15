import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/servicing/servicing.dart';
import 'package:pulse_mobile/providers/servicing/servicing_provider.dart';
import 'package:pulse_mobile/utils/util.dart';
import 'package:pulse_mobile/widgets/global_navigation_drawer.dart';

class ServicingDetailsScreen extends StatefulWidget {
  static String routeName = "/Servicing";
  final int ServicingId;

  const ServicingDetailsScreen(this.ServicingId, {super.key});

  @override
  State<ServicingDetailsScreen> createState() => _ServicingDetailsScreenState();
}

class _ServicingDetailsScreenState extends State<ServicingDetailsScreen> {
  bool _loading = false;

  ServicingProvider? _provider;
  Servicing? _data;

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
                          _data?.servicingNumber ?? "",
                          style: Theme.of(context).textTheme.titleLarge,
                        ),
                        const SizedBox(
                          height: 8,
                        ),
                        Text(
                            "Register Time · ${DateFormat.yMMMd().format(DateTime.now())} ${DateFormat.ms().format(DateTime.now())}",
                            style: Theme.of(context)
                                .textTheme
                                .bodyLarge
                                ?.copyWith(fontSize: 15)),
                        const SizedBox(
                          height: 6,
                        ),
                        Text(
                            "Last Updated · ${DateFormat.yMMMd().format(DateTime.now())} ${DateFormat.ms().format(DateTime.now())}",
                            style: Theme.of(context)
                                .textTheme
                                .bodyLarge
                                ?.copyWith(fontSize: 15)),
                        if (_data != null)
                          Column(
                            children: [
                              const SizedBox(
                                height: 8,
                              ),
                              Text(
                                  "Status · ${GetServicingStateName(ServicingState.values[_data!.status!])}",
                                  style: Theme.of(context)
                                      .textTheme
                                      .displayMedium
                                      ?.copyWith(fontSize: 14)),
                            ],
                          ),
                        const SizedBox(
                          height: 35,
                        ),
                        Text(
                          "CUSTOMER REQUEST",
                          style: Theme.of(context)
                              .textTheme
                              .titleLarge
                              ?.copyWith(fontSize: 18),
                        ),
                        const SizedBox(
                          height: 8,
                        ),
                        Text(
                          "${_data?.customerRequest}",
                          style: themeData.textTheme.bodyMedium,
                          textAlign: TextAlign.justify,
                        ),
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

  Future loadData() async {
    setState(() {
      _loading = true;
    });

    var tmpData = await _provider?.getDetails(widget.ServicingId);

    setState(() {
      _data = tmpData;
      _loading = false;
    });
  }
}
