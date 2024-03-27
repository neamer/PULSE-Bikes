import 'package:pulse_admin/data/product_category/product_category.dart';
import 'package:pulse_admin/providers/http/base/base_crud_provider.dart';

class GearCategoryProvider extends BaseCRUDProvider<ProductCategory> {
  GearCategoryProvider() : super('GearCategory');

  @override
  ProductCategory fromJson(data) {
    return ProductCategory.fromJson(data);
  }
}
