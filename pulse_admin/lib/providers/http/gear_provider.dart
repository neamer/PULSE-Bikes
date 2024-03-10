import 'package:pulse_admin/data/gear/gear.dart';
import 'package:pulse_admin/providers/http/base_provider.dart';

class GearProvider extends BaseProvider<Gear> {
  GearProvider() : super('Gear');

  @override
  Gear fromJson(data) {
    return Gear.fromJson(data);
  }
}
