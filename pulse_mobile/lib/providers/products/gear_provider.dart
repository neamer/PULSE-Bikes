import 'package:pulse_mobile/model/gear/gear.dart';
import 'package:pulse_mobile/providers/abstract/product_provider.dart';

class GearProvider extends ProductProvider<Gear> {
  GearProvider() : super("Gear");

  @override
  Gear fromJson(data) {
    return Gear.fromJson(data);
  }
}
