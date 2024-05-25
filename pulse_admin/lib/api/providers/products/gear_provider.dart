import 'package:pulse_admin/api/providers/base/base_crud_provider.dart';
import 'package:pulse_admin/api/types/gear/gear.dart';

class GearProvider extends BaseCRUDProvider<Gear> {
  GearProvider() : super('Gear');

  @override
  Gear fromJson(data) {
    return Gear.fromJson(data);
  }
}
