import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/abstract/product.dart';
import 'package:pulse_mobile/model/available_size/available_size.dart';
import 'package:pulse_mobile/model/gear/gear.dart';
import 'package:pulse_mobile/model/orders/order_detail_request.dart';
import 'package:pulse_mobile/model/part/part.dart';
import 'package:pulse_mobile/providers/abstract/product_provider.dart';
import 'package:pulse_mobile/utils/messages.dart';
import 'package:pulse_mobile/utils/numeric_range_formatter.dart';
import 'package:pulse_mobile/widgets/global_navigation_drawer.dart';

import '../model/bicycle/bicycle.dart';

class ProductDetailsScreen<T extends Product,
    TProvider extends ProductProvider<T>> extends StatefulWidget {
  static String routeName = "/product";
  final int productId;

  const ProductDetailsScreen(this.productId, {super.key});

  @override
  State<ProductDetailsScreen<T, TProvider>> createState() =>
      _ProductDetailsScreenState<T, TProvider>();
}

class _ProductDetailsScreenState<T extends Product,
        TProvider extends ProductProvider<T>>
    extends State<ProductDetailsScreen<T, TProvider>> {
  TProvider? _provider;
  T? _product;
  bool _isSubmitting = false;

  final TextEditingController _quantityController =
      TextEditingController(text: "1");

  bool _loading = false;

  AvailableSize? _selectedSize;

  bool isDisabled() => _isSubmitting || T == Bicycle && _selectedSize == null;

  int getAvailableQty() {
    if (_product is Bicycle) {
      return _selectedSize?.availableQty ?? 0;
    } else if (_product is Gear) {
      return (_product as Gear).availableQty ?? 0;
    } else {
      return (_product as Part).availableQty ?? 0;
    }
  }

  void addToCart() async {
    setState(() {
      _isSubmitting = true;
    });
    final request = OrderDetailRequest.build(
        productId: _product?.id,
        quantity: int.tryParse(_quantityController.text),
        bicycleSizeId: _selectedSize?.bicycleSizeId);

    try {
      await _provider?.addToCart(request);

      Messages.errorMessage(context, "Successfully added $_product to cart!");
    } catch (e) {
      Messages.errorMessage(context, "Error while adding item to cart!");
    } finally {
      setState(() {
        _isSubmitting = false;
      });
    }
  }

  void preselectFirstAvailableSize() {
    if(_product == null) {
      return;
    }


    for (var availableSize in (_product as Bicycle).availableSizes!) {
      if(availableSize.availableQty != null && availableSize.availableQty! > 0) {
        _selectedSize = availableSize;
        return;
      }
    }

  }

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
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Container(
                      height: 270,
                      color: Colors.grey.shade300,
                    ),
                    Container(
                      padding: const EdgeInsets.all(20),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text("Category: ${_product?.productCategory?.name}",
                              style: themeData.textTheme.bodyLarge
                                  ?.copyWith(color: Colors.white)),
                          const SizedBox(
                            height: 10,
                          ),
                          Text("${_product?.brand?.name} · ${_product?.model}",
                              style: themeData.textTheme.titleLarge),
                          const SizedBox(
                            height: 10,
                          ),
                          Text(
                            "${_product?.description}",
                            style: themeData.textTheme.bodyMedium,
                            textAlign: TextAlign.justify,
                          ),
                          const SizedBox(
                            height: 20,
                          ),
                          if (T == Bicycle)
                            Padding(
                              padding: const EdgeInsets.only(bottom: 8.0),
                              child: Wrap(
                                children: [
                                  ...?(_product as Bicycle)
                                      .availableSizes
                                      ?.map((size) => Container(
                                            margin: const EdgeInsets.all(5),
                                            child: OutlinedButton(
                                                style: ButtonStyle(
                                                    backgroundColor: MaterialStateProperty.all(_selectedSize
                                                                ?.bicycleSizeId ==
                                                            size.bicycleSizeId
                                                        ? Colors.white
                                                        : size.availableQty == 0
                                                            ? themeData
                                                                .primaryColor
                                                            : themeData
                                                                .colorScheme
                                                                .background),
                                                    side: MaterialStateProperty.all(BorderSide(
                                                        width: _selectedSize?.bicycleSizeId ==
                                                                size
                                                                    .bicycleSizeId
                                                            ? 0
                                                            : 1.0,
                                                        color: themeData
                                                            .primaryColor)),
                                                    padding: MaterialStateProperty.all(
                                                        const EdgeInsets.symmetric(
                                                            vertical: 15,
                                                            horizontal: 5))),
                                                onPressed: size.availableQty == 0
                                                    ? null
                                                    : () {
                                                        setState(() {
                                                          _selectedSize = size;
                                                        });
                                                      },
                                                child: Text(size.bicycleSize.toString(), style: themeData.textTheme.titleLarge?.copyWith(color: _selectedSize?.bicycleSizeId == size.bicycleSizeId ? themeData.colorScheme.background : Colors.white, fontSize: 18))),
                                          ))
                                ],
                              ),
                            ),
                          if (T != Bicycle || _selectedSize != null)
                            Center(
                              child: Text(
                                ("Available Qty: ${getAvailableQty()}"),
                                style: themeData.textTheme.titleLarge?.copyWith(
                                    fontSize: 16,
                                    color:
                                        themeData.colorScheme.primaryContainer),
                              ),
                            ),
                          const SizedBox(
                            height: 20,
                          ),
                          Center(
                            child: Text(
                              ("${_product?.price.toString() ?? ""} KM"),
                              style: themeData.textTheme.titleLarge,
                            ),
                          ),
                          const SizedBox(
                            height: 20,
                          ),
                          Row(
                            children: [
                              SizedBox(
                                width: 75,
                                child: TextField(
                                  controller: _quantityController,
                                  style: themeData.textTheme.bodyLarge,
                                  enabled: !isDisabled(),
                                  decoration: InputDecoration(
                                      enabledBorder: const OutlineInputBorder(
                                          borderSide: BorderSide(
                                              color: Color.fromRGBO(
                                                  43, 43, 62, 1))),
                                      labelText: "Qty",
                                      labelStyle:
                                          themeData.textTheme.bodyLarge),
                                  // backgroundColor: themeData.backgroundColor,
                                  keyboardType: TextInputType.number,
                                  inputFormatters: <TextInputFormatter>[
                                    FilteringTextInputFormatter.digitsOnly,
                                    NumericRangeFormatter(
                                        min: 1,
                                        max: getAvailableQty().toDouble())
                                  ], // Only numbers can be entered
                                ),
                              ),
                              const SizedBox(
                                width: 10,
                              ),
                              Expanded(
                                child: OutlinedButton(
                                    style: ButtonStyle(
                                        backgroundColor:
                                            MaterialStateProperty.all<Color>(
                                                Colors.white),
                                        padding: MaterialStateProperty.all(
                                            const EdgeInsets.symmetric(
                                                vertical: 20, horizontal: 30))),
                                    onPressed: isDisabled() ? null : addToCart,
                                    child: _isSubmitting
                                        ? SizedBox(
                                          height: 20,
                                          width: 20,
                                          child: CircularProgressIndicator(
                                              color: themeData
                                                  .colorScheme.background,
                                            ),
                                        )
                                        : Text("ADD TO CART",
                                            style: themeData
                                                .textTheme.titleLarge
                                                ?.copyWith(
                                                    color: themeData
                                                        .colorScheme.background,
                                                    fontSize: 18))),
                              )
                            ],
                          )
                        ],
                      ),
                    )
                  ],
                ),
              ));
  }

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

    try {
      _product = await _provider?.getById(widget.productId, searchObject);
      preselectFirstAvailableSize();
    } catch (e) {
      log(e.toString());
      Navigator.pop(context);
    }
    setState(() {
      _loading = false;
    });
  }
}
