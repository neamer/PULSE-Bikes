import '../model/brand/brand.dart';
import 'base_provider.dart';

class BrandProvider extends BaseProvider<Brand> {
  BrandProvider() : super("Brand");

  @override
  Brand fromJson(data) {
    return Brand.fromJson(data);
  }
}
