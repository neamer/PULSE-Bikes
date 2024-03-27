import 'package:pulse_mobile/model/bicycle_size/bicycle_size.dart';
import 'package:pulse_mobile/providers/abstract/base_crud_provider.dart';

class BicycleSizeProvider extends BaseCRUDProvider<BicycleSize> {
  BicycleSizeProvider() : super("BicycleSize");

  @override
  BicycleSize fromJson(data) {
    return BicycleSize.fromJson(data);
  }
}
