import 'package:pulse_mobile/model/abstract/product.dart';
import 'package:pulse_mobile/model/product_category/product_category.dart';
import 'package:pulse_mobile/providers/abstract/base_provider.dart';

class ProductCategoryProvider<T extends Product>
    extends BaseProvider<ProductCategory> {
  ProductCategoryProvider() : super("${T.toString()}Category");

  @override
  ProductCategory fromJson(data) {
    return ProductCategory.fromJson(data);
  }
}
