import 'package:pulse_admin/api/providers/base/base_crud_provider.dart';
import 'package:pulse_admin/api/types/product_category/product_category.dart';

class BicycleCategoryProvider extends BaseCRUDProvider<ProductCategory> {
  BicycleCategoryProvider() : super('BicycleCategory');

  @override
  ProductCategory fromJson(data) {
    return ProductCategory.fromJson(data);
  }
}
