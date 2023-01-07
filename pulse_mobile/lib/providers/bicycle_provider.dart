import 'package:pulse_mobile/model/bicycle/bicycle.dart';
import 'base_provider.dart';

class BicycleProvider extends BaseProvider<Bicycle> {
  BicycleProvider() : super("Bicycle");

  @override
  Bicycle fromJson(data) {
    return Bicycle.fromJson(data);
  }
}
