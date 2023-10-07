import 'package:pulse_mobile/model/gear/gear.dart';
import 'package:pulse_mobile/providers/abstract/base_crud_provider.dart';

class GearProvider extends BaseCRUDProvider<Gear> {
  GearProvider() : super("Gear");

  @override
  Gear fromJson(data) {
    return Gear.fromJson(data);
  }
}
