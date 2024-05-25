import 'package:pulse_admin/api/providers/base/base_crud_provider.dart';
import 'package:pulse_admin/api/types/brand/brand.dart';

class BrandProvider extends BaseCRUDProvider<Brand> {
  BrandProvider() : super('Brand');

  @override
  Brand fromJson(data) {
    return Brand.fromJson(data);
  }
}
