import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/bicycle/bicycle.dart';
import 'package:pulse_mobile/model/gear/gear.dart';
import 'package:pulse_mobile/model/product/product.dart';
import 'package:pulse_mobile/providers/base_crud_provider.dart';
import 'package:pulse_mobile/providers/bicycle_provider.dart';
import 'package:pulse_mobile/providers/gear_provider.dart';
import 'package:pulse_mobile/utils/config.dart';
import 'package:pulse_mobile/widgets/filter_drawer.dart';
import 'package:pulse_mobile/widgets/navigation_drawer.dart';
import 'package:pulse_mobile/widgets/product_grid_tile.dart';
import 'package:pulse_mobile/widgets/product_list_tile.dart';

import '../providers/part_provider.dart';

enum ViewType { List, Grid }

class ProductSearchObject {
  List<int>? bicycleSizes;
  int? brandId;
  int? productCategoryId;
  RangeValues? price = RangeValues(0, 100000);

  ProductSearchObject(
      {this.bicycleSizes = null,
      this.brandId = null,
      this.productCategoryId = null,
      this.price = null});
}

class ProductSearchScreen<T extends Product, TProvider> extends StatefulWidget {
  static String routeName = "/search";

  @override
  State<ProductSearchScreen<T, TProvider>> createState() =>
      _ProductSearchScreenState<T, TProvider>();
}

class _ProductSearchScreenState<T extends Product, TProvider>
    extends State<ProductSearchScreen<T, TProvider>> {
  final ScrollController _scrollController = ScrollController();
  bool _showBackToTop = false;
  final _searchObject = ProductSearchObject();

  TProvider? _provider = null;
  final _searchController = TextEditingController();
  String _searchCriteria = "";

  ViewType _viewType = ViewType.List;
  List<T> _data = [];

  int _page = 0;

  @override
  void initState() {
    super.initState();

    _provider = context.read<TProvider>();

    loadData();

    _scrollController.addListener(() {
      double showoffset = 2000.0;

      if (_scrollController.position.pixels > showoffset != _showBackToTop) {
        setState(() {
          _showBackToTop = _scrollController.position.pixels > showoffset;
        });
      }

      if (_scrollController.position.atEdge) {
        bool isTop = _scrollController.position.pixels == 0;
        if (isTop) {
        } else {
          loadData();
        }
      }
    });
  }

  Future resetData(ProductSearchObject? filterObject) async {
    print(filterObject?.brandId);
    await _scrollController.animateTo(0,
        duration: Duration(milliseconds: 500), curve: Curves.fastOutSlowIn);
    setState(() {
      _page = 0;
      _data = [];
    });
    loadData(filterObject: filterObject);
  }

  Future loadData({ProductSearchObject? filterObject = null}) async {
    if (_page != -1) {
      var searchObject = {
        "AnyField": _searchCriteria,
        "IncludeBrand": true,
        "IncludeCategory": true,
        "IncludeSizes": true,
        "Page": _page,
        "PageSize": Config.productItemsPerPage,
        "BrandId": filterObject?.brandId,
        "ProductCategoryId": filterObject?.productCategoryId,
        "PriceFrom": filterObject?.price?.start,
        "PriceTo": filterObject?.price?.end,
        "BicycleSizes": filterObject?.bicycleSizes,
      };

      var tmpData = await (_provider as BaseCRUDProvider)?.get(searchObject);

      if (tmpData!.length < Config.productItemsPerPage) {
        _page = -1;
      } else {
        setState(() {
          _data += (tmpData as List<T>);
          _page++;
        });
      }
    }
  }

  search() {
    setState(() {
      _searchCriteria = _searchController.text;
      _data = [];
      _page = 0;
      loadData();
    });
  }

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);
    var size = MediaQuery.of(context).size;

    /*24 is for notification bar on Android*/
    final double itemHeight = 247;
    final double itemWidth = (size.width - 30) / 2;

    return Scaffold(
      floatingActionButtonLocation: FloatingActionButtonLocation.centerTop,
      floatingActionButton: _buildBackToTopButton(),
      drawer: SafeArea(child: Drawer(child: NavigationDrawer())),
      endDrawer: SafeArea(child: Drawer(child: FilterDrawer<T>(resetData))),
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
      body: ListView(
        controller: _scrollController,
        children: [
          SizedBox(
            height: 10,
          ),
          Row(
            children: [
              Flexible(
                child: _buildSearchBar(themeData),
              ),
              Container(
                decoration: BoxDecoration(
                    border: Border.all(color: themeData.primaryColor),
                    borderRadius: BorderRadius.all(Radius.circular(7))),
                child: IconButton(
                  iconSize: 32,
                  icon: Icon(
                    _viewType == ViewType.List
                        ? Icons.grid_view_sharp
                        : Icons.table_rows_sharp,
                    color: themeData.primaryColor,
                  ),
                  onPressed: () {
                    setState(() {
                      _viewType = _viewType == ViewType.List
                          ? ViewType.Grid
                          : ViewType.List;
                    });
                  },
                  padding: EdgeInsets.all(13),
                ),
              ),
              SizedBox(
                width: 14,
              ),
            ],
          ),
          _viewType == ViewType.List
              ? ListView.builder(
                  shrinkWrap: true,
                  physics: ScrollPhysics(),
                  itemCount: _data.length,
                  itemBuilder: (ctx, index) => ProductListTile<T>(_data[index]))
              : GridView.builder(
                  padding: EdgeInsets.symmetric(horizontal: 10),
                  shrinkWrap: true,
                  physics: ScrollPhysics(),
                  gridDelegate: SliverGridDelegateWithMaxCrossAxisExtent(
                      maxCrossAxisExtent: 200,
                      childAspectRatio: itemWidth / itemHeight,
                      crossAxisSpacing: 10,
                      mainAxisSpacing: 10),
                  itemCount: _data.length,
                  itemBuilder: (ctx, index) => ProductGridTile(_data[index])),
          _page == -1
              ? Center(
                  child: Padding(
                  padding: EdgeInsets.all(20),
                  child: Text(
                    "No more products to show!",
                    style: themeData.textTheme.bodyText1,
                  ),
                ))
              : const Center(
                  child: Padding(
                  padding: EdgeInsets.all(20),
                  child: CircularProgressIndicator(),
                ))
        ],
      ),
    );
  }

  Widget _buildBackToTopButton() => AnimatedOpacity(
        duration: Duration(milliseconds: 200), //show/hide animation
        opacity:
            _showBackToTop ? 1.0 : 0.0, //set obacity to 1 on visible, or hide
        child: Padding(
          padding: const EdgeInsets.only(top: 80),
          child: Container(
            decoration: BoxDecoration(
                border: Border.all(
                    color: Color.fromARGB(255, 84, 117, 145), width: 1),
                color: Color.fromRGBO(19, 19, 29, 0.9),
                shape: BoxShape.circle),
            height: 60,
            child: Center(
              child: IconButton(
                iconSize: 35,
                icon: Icon(
                  Icons.keyboard_arrow_up_outlined,
                  color: Color.fromRGBO(188, 188, 188, 1),
                ),
                onPressed: () {
                  _scrollController.animateTo(
                      //go to top of scroll
                      0, //scroll offset to go
                      duration:
                          Duration(milliseconds: 500), //duration of scroll
                      curve: Curves.fastOutSlowIn //scroll type
                      );
                },
              ),
            ),
          ),
        ),
      );

  Widget _buildSearchBar(ThemeData themeData) => Padding(
        padding: const EdgeInsets.symmetric(vertical: 15, horizontal: 15),
        child: TextField(
          controller: _searchController,
          onSubmitted: (value) {
            search();
          },
          style: themeData.textTheme.bodyText1,
          decoration: InputDecoration(
              prefixIcon: Icon(
                Icons.search,
                color: themeData.primaryColor,
              ),
              enabledBorder: OutlineInputBorder(
                  borderSide:
                      BorderSide(color: themeData.primaryColor, width: 1),
                  borderRadius: BorderRadius.all(Radius.circular(7))),
              hintStyle: themeData.textTheme.bodyText1,
              hintText: "Enter search criteria"),
        ),
      );
}
