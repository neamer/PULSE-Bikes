import 'package:pulse_mobile/model/bicycle/bicycle.dart';
import 'package:pulse_mobile/providers/abstract/base_crud_provider.dart';

class BicycleProvider extends BaseCRUDProvider<Bicycle> {
  BicycleProvider() : super("Bicycle");

  @override
  Bicycle fromJson(data) {
    return Bicycle.fromJson(data);
  }
}
