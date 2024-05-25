import 'package:pulse_admin/api/providers/base/base_crud_provider.dart';
import 'package:pulse_admin/api/types/product_category/product_category.dart';

class PartCategoryProvider extends BaseCRUDProvider<ProductCategory> {
  PartCategoryProvider() : super('PartCategory');

  @override
  ProductCategory fromJson(data) {
    return ProductCategory.fromJson(data);
  }
}
