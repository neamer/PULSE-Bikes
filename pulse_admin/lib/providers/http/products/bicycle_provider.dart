import 'package:pulse_admin/data/bicycle/bicycle.dart';
import 'package:pulse_admin/providers/http/base/base_crud_provider.dart';

class BicycleProvider extends BaseCRUDProvider<Bicycle> {
  BicycleProvider() : super('Bicycle');

  @override
  Bicycle fromJson(data) {
    return Bicycle.fromJson(data);
  }
}
