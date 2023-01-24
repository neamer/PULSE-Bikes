import 'package:pulse_mobile/model/bicycle/bicycle.dart';
import 'base_crud_provider.dart';

class BicycleProvider extends BaseCRUDProvider<Bicycle> {
  BicycleProvider() : super("Bicycle");

  @override
  Bicycle fromJson(data) {
    return Bicycle.fromJson(data);
  }
}
