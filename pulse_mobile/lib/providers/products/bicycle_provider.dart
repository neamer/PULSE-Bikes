import 'package:pulse_mobile/model/bicycle/bicycle.dart';
import 'package:pulse_mobile/providers/abstract/product_provider.dart';

class BicycleProvider extends ProductProvider<Bicycle> {
  BicycleProvider() : super("Bicycle");

  @override
  Bicycle fromJson(data) {
    return Bicycle.fromJson(data);
  }
}
