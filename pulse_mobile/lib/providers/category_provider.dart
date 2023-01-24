import 'package:pulse_mobile/model/product/product.dart';
import 'package:pulse_mobile/model/product_category/product_category.dart';

import '../model/brand/brand.dart';
import 'base_provider.dart';

class ProductCategoryProvider<T extends Product>
    extends BaseProvider<ProductCategory> {
  ProductCategoryProvider() : super("${T.toString()}Category");

  @override
  ProductCategory fromJson(data) {
    return ProductCategory.fromJson(data);
  }
}
