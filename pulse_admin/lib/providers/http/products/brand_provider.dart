import 'package:pulse_admin/data/brand/brand.dart';
import 'package:pulse_admin/providers/http/base/base_crud_provider.dart';

class BrandProvider extends BaseCRUDProvider<Brand> {
  BrandProvider() : super('Brand');

  @override
  Brand fromJson(data) {
    return Brand.fromJson(data);
  }
}
