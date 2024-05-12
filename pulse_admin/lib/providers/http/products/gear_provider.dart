import 'package:pulse_admin/data/gear/gear.dart';
import 'package:pulse_admin/providers/http/base/base_crud_provider.dart';

class GearProvider extends BaseCRUDProvider<Gear> {
  GearProvider() : super('Gear');

  @override
  Gear fromJson(data) {
    return Gear.fromJson(data);
  }
}