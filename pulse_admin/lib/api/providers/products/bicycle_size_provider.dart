import 'package:pulse_admin/api/providers/base/base_crud_provider.dart';
import 'package:pulse_admin/api/types/bicycle_size/bicycle_size.dart';

class BicycleSizeProvider extends BaseCRUDProvider<BicycleSize> {
  BicycleSizeProvider() : super('BicycleSize');

  @override
  BicycleSize fromJson(data) {
    return BicycleSize.fromJson(data);
  }
}
