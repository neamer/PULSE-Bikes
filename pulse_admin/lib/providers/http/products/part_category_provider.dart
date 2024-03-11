import 'package:pulse_admin/data/product_category/product_category.dart';
import 'package:pulse_admin/providers/http/base/base_provider.dart';

class PartCategoryProvider extends BaseProvider<ProductCategory> {
  PartCategoryProvider() : super('PartCategory');

  @override
  ProductCategory fromJson(data) {
    return ProductCategory.fromJson(data);
  }
}
