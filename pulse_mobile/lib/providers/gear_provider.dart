import '../model/gear/gear.dart';
import 'base_provider.dart';

class GearProvider extends BaseProvider<Gear> {
  GearProvider() : super("Gear");

  @override
  Gear fromJson(data) {
    return Gear.fromJson(data);
  }
}
