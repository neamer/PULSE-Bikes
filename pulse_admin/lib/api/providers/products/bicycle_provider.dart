import 'package:pulse_admin/api/providers/base/base_crud_provider.dart';
import 'package:pulse_admin/api/types/bicycle/bicycle.dart';

class BicycleProvider extends BaseCRUDProvider<Bicycle> {
  BicycleProvider() : super('Bicycle');

  @override
  Bicycle fromJson(data) {
    return Bicycle.fromJson(data);
  }
}
