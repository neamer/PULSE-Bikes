import 'package:pulse_admin/data/available_size/available_size.dart';
import 'package:pulse_admin/providers/http/base/base_crud_provider.dart';

class AvailableSizeProvider extends BaseCRUDProvider<AvailableSize> {
  AvailableSizeProvider() : super('AvailableSize');

  @override
  AvailableSize fromJson(data) {
    return AvailableSize.fromJson(data);
  }
}
