import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/abstract/product.dart';
import 'package:pulse_mobile/providers/base_crud_provider.dart';
import 'package:pulse_mobile/widgets/global_navigation_drawer.dart';

class ProductDetailsScreen<T extends Product,
    TProvider extends BaseCRUDProvider<T>> extends StatefulWidget {
  static String routeName = "/product";
  final int productId;

  ProductDetailsScreen(this.productId);

  @override
  State<ProductDetailsScreen<T, TProvider>> createState() =>
      _ProductDetailsScreenState<T, TProvider>();
}

class _ProductDetailsScreenState<T extends Product,
        TProvider extends BaseCRUDProvider<T>>
    extends State<ProductDetailsScreen<T, TProvider>> {
  TProvider? _provider = null;
  T? _product = null;

  bool _loading = false;

  @override
  void initState() {
    _provider = context.read<TProvider>();
    loadData();

    super.initState();
  }

  Future loadData() async {
    setState(() {
      _loading = true;
    });

    var searchObject = {
      "IncludeBrand": true,
      "IncludeCategory": true,
      "IncludeSizes": true,
    };

  print(widget.productId);

    try {
      _product = await _provider?.getById(widget.productId, searchObject);
    } catch (e) {
      log(e.toString());
      Navigator.pop(context);
    }
    setState(() {
      _loading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);
    var size = MediaQuery.of(context).size;

    return Scaffold(
        drawer: SafeArea(child: Drawer(child: GlobalNavigationDrawer())),
        appBar: AppBar(
          title: Image.asset(
            "assets/images/logo.png",
            fit: BoxFit.contain,
            height: 50,
          ),
          actions: [
            Builder(
              builder: (context) {
                return IconButton(
                  icon: Icon(Icons.filter_list),
                  onPressed: () {
                    Scaffold.of(context).openEndDrawer();
                  },
                );
              },
            )
          ],
          toolbarHeight: 75,
          centerTitle: true,
          shape: Border(bottom: BorderSide(color: Colors.cyan, width: 1)),
        ),
        body: _loading
            ? const Center(
                child: Padding(
                padding: EdgeInsets.all(20),
                child: CircularProgressIndicator(),
              ))
            : Column(
                children: [
                  Container(
                    height: 270,
                    color: Colors.grey.shade300,
                  ),
                  Container(
                    padding: EdgeInsets.all(15),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text("Category: ${_product?.productCategory?.name}",
                            style: themeData.textTheme.bodyText1),
                        Text("${_product?.brand?.name} · ${_product?.model}",
                            style: themeData.textTheme.headline6),
                      ],
                    ),
                  )
                ],
              ));
  }
}
