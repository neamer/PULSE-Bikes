import 'package:pulse_mobile/model/brand/brand.dart';
import 'package:pulse_mobile/providers/abstract/base_provider.dart';

class BrandProvider extends BaseProvider<Brand> {
  BrandProvider() : super("Brand");

  @override
  Brand fromJson(data) {
    return Brand.fromJson(data);
  }
}
