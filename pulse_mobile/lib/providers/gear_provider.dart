import '../model/gear/gear.dart';
import 'base_crud_provider.dart';

class GearProvider extends BaseCRUDProvider<Gear> {
  GearProvider() : super("Gear");

  @override
  Gear fromJson(data) {
    return Gear.fromJson(data);
  }
}
