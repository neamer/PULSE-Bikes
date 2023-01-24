import 'package:flutter/material.dart';
import 'package:non_linear_slider/models/interval.dart';
import 'package:non_linear_slider/non_linear_slider.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/brand/brand.dart';
import 'package:pulse_mobile/model/product/product.dart';
import 'package:pulse_mobile/model/product_category/product_category.dart';
import 'package:pulse_mobile/pages/product_search_screen.dart';
import 'package:pulse_mobile/providers/bicycle_size_provider.dart';
import 'package:pulse_mobile/providers/brand_provider.dart';
import 'package:pulse_mobile/providers/category_provider.dart';

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

  FilterDrawer(this.reloadData);

  @override
  State<FilterDrawer> createState() => _FilterDrawerState<TProduct>();
}

class _FilterDrawerState<TProduct extends Product> extends State<FilterDrawer> {
  final _searchObject = ProductSearchObject();
  RangeValues _currentRangeValues = const RangeValues(0, 100000);

  BrandProvider? _brandProvider = null;
  ProductCategoryProvider<TProduct>? _categoryProvider = null;
  BicycleSizeProvider? _bicycleSizeProvider = null;

  SortByOption _sortBy = SortByOptions[0];

  List<Brand> _brands = [];
  Brand? _selectedBrand;

  List<ProductCategory> _categories = [];
  ProductCategory? _selectedCategory;

  List<BicycleSize> _bicycleSizes = [];

  @override
  void initState() {
    super.initState();
    _brandProvider = context.read<BrandProvider>();
    _categoryProvider = context.read<ProductCategoryProvider<TProduct>>();
    _bicycleSizeProvider = context.read<BicycleSizeProvider>();

    _brandProvider?.get(null).then((value) {
      setState(() {
        _brands = value;
      });
    });

    _categoryProvider?.get(null).then((value) {
      setState(() {
        _categories = value;
      });
    });

    _bicycleSizeProvider?.get(null).then((value) {
      setState(() {
        _bicycleSizes = value;
      });
    });
  }

  void onRefresh() {
    // OBJECT DONT GET FILLED BY DROPDOWN
    print(_selectedBrand);
    final searchObject = ProductSearchObject(
        brandId: _selectedBrand?.brandId,
        productCategoryId: _selectedCategory?.id,
        price:
            _currentRangeValues.start != 0 && _currentRangeValues.end != 100000
                ? _currentRangeValues
                : null);

    widget.reloadData(searchObject);
    Navigator.pop(context);
  }

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return SingleChildScrollView(
      child: Container(
          color: themeData.backgroundColor,
          child: Padding(
            padding: const EdgeInsets.all(15.0),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                SizedBox(
                  height: 15,
                ),
                ..._buildDropDownButton(
                    "SORT BY", SortByOptions, (value) {}, themeData,
                    selected: _sortBy),
                SizedBox(
                  height: 25,
                ),
                Divider(
                  color: Color.fromARGB(255, 183, 183, 197),
                ),
                SizedBox(
                  height: 25,
                ),
                ..._buildDropDownButton<Brand>("BRANDS", _brands, (value) {
                  setState(() {
                    this._selectedBrand = value;
                  });
                }, themeData),
                SizedBox(
                  height: 25,
                ),
                ..._buildDropDownButton("CATEGORY", _categories, (value) {
                  setState(() {
                    this._selectedCategory = value;
                  });
                }, themeData),
                SizedBox(
                  height: 25,
                ),
                Text(
                  "PRICE",
                  style: themeData.textTheme.headline6?.copyWith(fontSize: 18),
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
                SizedBox(
                  height: 25,
                ),
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Text(
                      "SIZES",
                      style:
                          themeData.textTheme.headline6?.copyWith(fontSize: 18),
                    ),
                    Text(
                      "CHECK ALL",
                      style: themeData.textTheme.headline6?.copyWith(
                          fontSize: 16, decoration: TextDecoration.underline),
                    ),
                  ],
                ),
                SizedBox(
                  height: 15,
                ),
                ..._bicycleSizes.map((e) => Row(
                      children: [
                        Checkbox(value: true, onChanged: (value) {}),
                        Text(e.toString(),
                            style: themeData.textTheme.headline6
                                ?.copyWith(fontSize: 18)),
                      ],
                    )),
                SizedBox(
                  height: 25,
                ),
                OutlinedButton(
                  onPressed: () => widget.reloadData(_searchObject),
                  style: OutlinedButton.styleFrom(
                      textStyle:
                          themeData.textTheme.headline6?.copyWith(fontSize: 20),
                      side: BorderSide(
                          width: 2.0,
                          color: Color.fromARGB(255, 222, 224, 226))),
                  child: Padding(
                    padding: const EdgeInsets.symmetric(vertical: 20.0),
                    child: Center(
                      child: const Text("REFRESH"),
                    ),
                  ),
                )
              ],
            ),
          )),
    );
  }

  List<Widget> _buildDropDownButton<T>(String label, List<T> options,
          Function(T?) onChanged, ThemeData themeData,
          {T? selected = null}) =>
      <Widget>[
        Text(
          label,
          style: themeData.textTheme.headline6?.copyWith(fontSize: 18),
        ),
        SizedBox(
          height: 10,
        ),
        DropdownButtonFormField(
            style: themeData.textTheme.bodyText1,
            decoration: const InputDecoration(
              enabledBorder: OutlineInputBorder(
                  borderSide: BorderSide(color: Color.fromRGBO(43, 43, 62, 1))),
            ),
            dropdownColor: themeData.backgroundColor,
            value: selected,
            items: options
                .map((e) => DropdownMenuItem(
                      child: Text(e.toString()),
                      value: e,
                    ))
                .toList(),
            icon: const Icon(Icons.keyboard_arrow_down),
            onChanged: ((value) {
              onChanged(value);
            }))
      ];
}
