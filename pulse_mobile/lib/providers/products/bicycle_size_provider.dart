import 'package:pulse_mobile/model/bicycle_size/bicycle_size.dart';
import 'package:pulse_mobile/providers/abstract/base_provider.dart';

class BicycleSizeProvider extends BaseProvider<BicycleSize> {
  BicycleSizeProvider() : super("BicycleSize");

  @override
  BicycleSize fromJson(data) {
    return BicycleSize.fromJson(data);
  }
}
