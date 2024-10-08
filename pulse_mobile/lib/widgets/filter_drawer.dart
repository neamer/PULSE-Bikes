import 'package:flutter/material.dart';
import 'package:non_linear_slider/models/interval.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/brand/brand.dart';
import 'package:pulse_mobile/model/abstract/product.dart';
import 'package:pulse_mobile/model/product_category/product_category.dart';
import 'package:pulse_mobile/providers/products/bicycle_size_provider.dart';
import 'package:pulse_mobile/providers/products/brand_provider.dart';
import 'package:pulse_mobile/providers/products/category_provider.dart';
import 'package:pulse_mobile/screens/product_search_screen.dart';

import '../model/bicycle/bicycle.dart';
import '../model/bicycle_size/bicycle_size.dart';
import 'non_linear_range_slider.dart';

enum SORT_BY { NEWEST, OLDEST, LOWEST_PRICE, HIGHEST_PRICE }

class SortByOption {
  final SORT_BY option;

  const SortByOption(this.option);

  @override
  String toString() {
    switch (option) {
      case SORT_BY.NEWEST:
        return "Newest";

      case SORT_BY.OLDEST:
        return "Oldest";

      case SORT_BY.LOWEST_PRICE:
        return "Lowest Price";

      case SORT_BY.HIGHEST_PRICE:
        return "Highest Price";
    }
  }
}

const SortByOptions = <SortByOption>[
  SortByOption(SORT_BY.NEWEST),
  SortByOption(SORT_BY.OLDEST),
  SortByOption(SORT_BY.LOWEST_PRICE),
  SortByOption(SORT_BY.HIGHEST_PRICE),
];

class FilterDrawer<TProduct extends Product> extends StatefulWidget {
  final Function reloadData;
  final ProductSearchObject _currentConfig;

  const FilterDrawer(this.reloadData, this._currentConfig, {super.key});

  @override
  State<FilterDrawer> createState() => _FilterDrawerState<TProduct>();
}

class _FilterDrawerState<TProduct extends Product> extends State<FilterDrawer> {
  RangeValues _currentRangeValues = const RangeValues(0, 100000);

  BrandProvider? _brandProvider;
  ProductCategoryProvider<TProduct>? _categoryProvider;
  BicycleSizeProvider? _bicycleSizeProvider;

  SortByOption _sortBy = SortByOptions[0];

  List<Brand> _brands = [];
  Brand? _selectedBrand;

  List<ProductCategory> _categories = [];
  ProductCategory? _selectedCategory;

  List<BicycleSize> _bicycleSizes = [];
  List<BicycleSize> _selectedBicycleSizes = [];

  final isBicycle = TProduct is Bicycle;

  @override
  void initState() {
    super.initState();
    initValues();
  }

  void initValues() async {
    _brandProvider = context.read<BrandProvider>();
    _categoryProvider = context.read<ProductCategoryProvider<TProduct>>();
    _bicycleSizeProvider = context.read<BicycleSizeProvider>();

    await _brandProvider?.get(null).then((value) {
      setState(() {
        _brands = value;
        _selectedBrand = widget._currentConfig.brandId != null
            ? value.singleWhere(
                (element) => element.id == widget._currentConfig.brandId)
            : null;
      });
    });

    await _categoryProvider?.get(null).then((value) {
      setState(() {
        _categories = value;
        _selectedCategory = widget._currentConfig.productCategoryId != null
            ? value.singleWhere((element) =>
                element.id == widget._currentConfig.productCategoryId)
            : null;
      });
    });

    await _bicycleSizeProvider?.get(null).then((value) {
      setState(() {
        _bicycleSizes = value;
        _selectedBicycleSizes = widget._currentConfig.bicycleSizes != null
            ? _bicycleSizes
                .where((element) =>
                    widget._currentConfig.bicycleSizes?.contains(element.id) ??
                    false)
                .toList()
            : [...value];
      });
    });

    if (widget._currentConfig.price != null) {
      _currentRangeValues = widget._currentConfig.price!;
    }
  }

  void onRefresh() {
    widget._currentConfig.brandId = _selectedBrand?.id;
    widget._currentConfig.productCategoryId = _selectedCategory?.id;
    widget._currentConfig.price = _currentRangeValues;
    widget._currentConfig.bicycleSizes =
        _selectedBicycleSizes.map((e) => e.id ?? -1).toList();

    widget.reloadData();
    Navigator.pop(context);
  }

  bool isChecked(BicycleSize item) => _selectedBicycleSizes.contains(item);
  void check(BicycleSize item) =>
      setState(() => _selectedBicycleSizes.add(item));
  void uncheck(BicycleSize item) =>
      setState(() => _selectedBicycleSizes.remove(item));

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);
    return Drawer(
      child: SingleChildScrollView(
        child: Container(
            constraints:
                BoxConstraints(minHeight: MediaQuery.of(context).size.height),
            color: themeData.colorScheme.background,
            child: Padding(
              padding: const EdgeInsets.all(15.0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  // ..._buildDropDownButton(
                  //     "SORT BY", SortByOptions, (value) {}, themeData,
                  //     selected: _sortBy),
                  // const SizedBox(
                  //   height: 25,
                  // ),
                  // const Divider(
                  //   color: Color.fromARGB(255, 183, 183, 197),
                  // ),
                  const SizedBox(
                    height: 25,
                  ),
                  ..._buildDropDownButton<Brand>("BRANDS", _brands, (value) {
                    setState(() {
                      this._selectedBrand = value;
                    });
                  }, themeData, selected: _selectedBrand),
                  const SizedBox(
                    height: 25,
                  ),
                  ..._buildDropDownButton("CATEGORY", _categories, (value) {
                    setState(() {
                      this._selectedCategory = value;
                    });
                  }, themeData, selected: _selectedCategory),
                  const SizedBox(
                    height: 25,
                  ),
                  Text(
                    "PRICE",
                    style: themeData.textTheme.headlineSmall
                        ?.copyWith(fontSize: 18, color: Colors.white),
                  ),
                  NonLinearRangeSlider(
                    intervals: [
                      NLSInterval(0, 2000, 0.5),
                      NLSInterval(2000, 10000, 0.25),
                      NLSInterval(10000, 100000, 0.25),
                    ],
                    divisions: 80,
                    values: _currentRangeValues,
                    onChanged: (RangeValues values) {
                      setState(() {
                        _currentRangeValues = values;
                      });
                    },
                  ),
                  const SizedBox(
                    height: 25,
                  ),
                  if (TProduct == Bicycle)
                    Column(
                      children: [
                        Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Text(
                              "SIZES",
                              style: themeData.textTheme.headlineSmall
                                  ?.copyWith(fontSize: 18, color: Colors.white),
                            ),
                            // Text(
                            //   "CHECK ALL",
                            //   style: themeData.textTheme.headlineSmall
                            //       ?.copyWith(
                            //           fontSize: 16,
                            //           decoration: TextDecoration.underline),
                            // ),
                          ],
                        ),
                        const SizedBox(
                          height: 15,
                        ),
                        Container(
                          constraints: const BoxConstraints(minHeight: 50),
                          child: Column(
                            children: [
                              ..._bicycleSizes.map((e) => Row(
                                    children: [
                                      Checkbox(
                                          activeColor: Colors.green,
                                          value: isChecked(e),
                                          onChanged: (value) {
                                            print(value);
                                            if (value != null) {
                                              if (value) {
                                                check(e);
                                              } else {
                                                uncheck(e);
                                              }
                                            }
                                          }),
                                      Text(e.toString(),
                                          style: themeData
                                              .textTheme.headlineSmall
                                              ?.copyWith(
                                                  fontSize: 18,
                                                  color: Colors.white)),
                                    ],
                                  ))
                            ],
                          ),
                        ),
                      ],
                    ),
                  const SizedBox(
                    height: 25,
                  ),
                  OutlinedButton(
                    onPressed: onRefresh,
                    style: OutlinedButton.styleFrom(
                        textStyle: themeData.textTheme.headlineSmall
                            ?.copyWith(fontSize: 20),
                        side: const BorderSide(
                            width: 2.0,
                            color: Color.fromARGB(255, 222, 224, 226))),
                    child: const Padding(
                      padding: EdgeInsets.symmetric(vertical: 20.0),
                      child: Center(
                        child: Text("REFRESH"),
                      ),
                    ),
                  )
                ],
              ),
            )),
      ),
    );
  }

  List<Widget> _buildDropDownButton<T>(String label, List<T> options,
          Function(T?) onChanged, ThemeData themeData,
          {T? selected}) =>
      <Widget>[
        Text(
          label,
          style: themeData.textTheme.headlineSmall
              ?.copyWith(fontSize: 18, color: Colors.white),
        ),
        const SizedBox(
          height: 10,
        ),
        DropdownButtonFormField(
            style: themeData.textTheme.bodyMedium,
            decoration: const InputDecoration(
              enabledBorder: OutlineInputBorder(
                  borderSide: BorderSide(color: Color.fromRGBO(43, 43, 62, 1))),
            ),
            dropdownColor: themeData.scaffoldBackgroundColor,
            value: selected,
            items: options
                .map((e) => DropdownMenuItem(
                      child: Text(
                        e.toString(),
                        style: TextStyle(color: Colors.white),
                      ),
                      value: e,
                    ))
                .toList(),
            icon: const Icon(Icons.keyboard_arrow_down),
            onChanged: ((value) {
              onChanged(value);
            }))
      ];
}
