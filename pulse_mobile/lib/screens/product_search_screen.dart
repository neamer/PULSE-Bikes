import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/abstract/product.dart';
import 'package:pulse_mobile/providers/abstract/product_provider.dart';
import 'package:pulse_mobile/screens/product_details_screen.dart';
import 'package:pulse_mobile/utils/config.dart';
import 'package:pulse_mobile/widgets/filter_drawer.dart';
import 'package:pulse_mobile/widgets/global_navigation_drawer.dart';
import 'package:pulse_mobile/widgets/product_grid_tile.dart';
import 'package:pulse_mobile/widgets/product_list_tile.dart';

enum ViewType { list, grid }

class ProductSearchObject {
  List<int>? bicycleSizes;
  int? brandId;
  int? productCategoryId;
  RangeValues? price = const RangeValues(0, 100000);

  ProductSearchObject(
      {this.bicycleSizes, this.brandId, this.productCategoryId, this.price});
}

class ProductSearchScreen<T extends Product,
    TProvider extends ProductProvider<T>> extends StatefulWidget {
  static String routeName = "/search";

  const ProductSearchScreen({super.key});

  @override
  State<ProductSearchScreen<T, TProvider>> createState() =>
      _ProductSearchScreenState<T, TProvider>();
}

class _ProductSearchScreenState<T extends Product,
        TProvider extends ProductProvider<T>>
    extends State<ProductSearchScreen<T, TProvider>> {
  final ScrollController _scrollController = ScrollController();
  bool _showBackToTop = false;
  final ProductSearchObject _searchObject = ProductSearchObject();

  TProvider? _provider;
  final _searchController = TextEditingController();
  String _searchCriteria = "";

  ViewType _viewType = ViewType.list;
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

  Future resetData() async {
    await _scrollController.animateTo(0,
        duration: const Duration(milliseconds: 500),
        curve: Curves.fastOutSlowIn);
    setState(() {
      _page = 0;
      _data = [];
    });
    loadData();
  }

  Future loadData() async {
    if (_page != -1) {
      var searchObject = {
        "IncludeBrand": true,
        "IncludeCategory": true,
        "IncludeSizes": true,
        "AnyField": _searchCriteria,
        "BrandId": _searchObject.brandId,
        "PriceFrom": _searchObject.price?.start,
        "PriceTo": _searchObject.price?.end,
        "BicycleSizes": _searchObject.bicycleSizes,
        "ProductCategoryId": _searchObject.productCategoryId,
        "Page": _page,
        "PageSize": Config.productItemsPerPage,
      };

      var tmpData = await _provider?.get(searchObject);

      if (tmpData!.length < Config.productItemsPerPage) {
        setState(() {
          _data += tmpData;
          _page = -1;
        });
      } else {
        setState(() {
          _data += tmpData;
          _page++;
        });
      }
    }
  }

  void openDetails(BuildContext context, int? productId) {
    productId != null
        ? Navigator.of(context).push(MaterialPageRoute<dynamic>(
            builder: (BuildContext context) {
              return ProductDetailsScreen<T, TProvider>(productId);
            },
          ))
        : null;
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
    const double itemHeight = 247;
    final double itemWidth = (size.width - 30) / 2;

    return Scaffold(
      floatingActionButtonLocation: FloatingActionButtonLocation.centerTop,
      floatingActionButton: _buildBackToTopButton(),
      drawer: const SafeArea(child: Drawer(child: GlobalNavigationDrawer())),
      endDrawer: SafeArea(child: FilterDrawer<T>(resetData, _searchObject)),
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
                icon: const Icon(Icons.filter_list),
                onPressed: () {
                  Scaffold.of(context).openEndDrawer();
                },
              );
            },
          )
        ],
        toolbarHeight: 75,
        centerTitle: true,
        shape: const Border(bottom: BorderSide(color: Colors.cyan, width: 1)),
      ),
      body: ListView(
        controller: _scrollController,
        children: [
          const SizedBox(
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
                    borderRadius: const BorderRadius.all(Radius.circular(7))),
                child: IconButton(
                  iconSize: 32,
                  icon: Icon(
                    _viewType == ViewType.list
                        ? Icons.grid_view_sharp
                        : Icons.table_rows_sharp,
                    color: themeData.primaryColor,
                  ),
                  onPressed: () {
                    setState(() {
                      _viewType = _viewType == ViewType.list
                          ? ViewType.grid
                          : ViewType.list;
                    });
                  },
                  padding: const EdgeInsets.all(13),
                ),
              ),
              const SizedBox(
                width: 14,
              ),
            ],
          ),
          _viewType == ViewType.list
              ? ListView.builder(
                  shrinkWrap: true,
                  physics: const ScrollPhysics(),
                  itemCount: _data.length,
                  itemBuilder: (ctx, index) => ProductListTile<T>(_data[index],
                      onTap: (productId) => openDetails(context, productId)))
              : GridView.builder(
                  padding: const EdgeInsets.symmetric(horizontal: 10),
                  shrinkWrap: true,
                  physics: const ScrollPhysics(),
                  gridDelegate: SliverGridDelegateWithMaxCrossAxisExtent(
                      maxCrossAxisExtent: 200,
                      childAspectRatio: itemWidth / itemHeight,
                      crossAxisSpacing: 10,
                      mainAxisSpacing: 10),
                  itemCount: _data.length,
                  itemBuilder: (ctx, index) => ProductGridTile(_data[index],
                      onTap: (productId) => openDetails(context, productId))),
          _page == -1
              ? Center(
                  child: Padding(
                  padding: const EdgeInsets.all(20),
                  child: Text(
                    "",
                    style: themeData.textTheme.bodyLarge,
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
        duration: const Duration(milliseconds: 200), //show/hide animation
        opacity:
            _showBackToTop ? 1.0 : 0.0, //set obacity to 1 on visible, or hide
        child: Padding(
          padding: const EdgeInsets.only(top: 80),
          child: Container(
            decoration: BoxDecoration(
                border: Border.all(
                    color: const Color.fromARGB(255, 84, 117, 145), width: 1),
                color: const Color.fromRGBO(19, 19, 29, 0.9),
                shape: BoxShape.circle),
            height: 60,
            child: Center(
              child: IconButton(
                iconSize: 35,
                icon: const Icon(
                  Icons.keyboard_arrow_up_outlined,
                  color: Color.fromRGBO(188, 188, 188, 1),
                ),
                onPressed: () {
                  _scrollController.animateTo(
                      //go to top of scroll
                      0, //scroll offset to go
                      duration: const Duration(
                          milliseconds: 500), //duration of scroll
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
          style: themeData.textTheme.bodyLarge,
          decoration: InputDecoration(
              prefixIcon: Icon(
                Icons.search,
                color: themeData.primaryColor,
              ),
              enabledBorder: OutlineInputBorder(
                  borderSide:
                      BorderSide(color: themeData.primaryColor, width: 1),
                  borderRadius: const BorderRadius.all(Radius.circular(7))),
              hintStyle: themeData.textTheme.bodyLarge,
              hintText: "Enter search criteria"),
        ),
      );
}
