import 'package:pulse_admin/data/product_category/product_category.dart';
import 'package:pulse_admin/providers/http/base_provider.dart';

class GearCategoryProvider extends BaseProvider<ProductCategory> {
  GearCategoryProvider() : super('GearCategory');

  @override
  ProductCategory fromJson(data) {
    return ProductCategory.fromJson(data);
  }
}
