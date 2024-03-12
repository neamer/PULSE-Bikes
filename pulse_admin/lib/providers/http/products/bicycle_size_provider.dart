import 'package:pulse_admin/data/bicycle_size/bicycle_size.dart';
import 'package:pulse_admin/providers/http/base/base_provider.dart';

class BicycleSizeProvider extends BaseProvider<BicycleSize> {
  BicycleSizeProvider() : super('BicycleSize');

  @override
  BicycleSize fromJson(data) {
    return BicycleSize.fromJson(data);
  }
}
