import 'package:pulse_admin/api/providers/base/base_crud_provider.dart';
import 'package:pulse_admin/api/types/available_size/available_size.dart';

class AvailableSizeProvider extends BaseCRUDProvider<AvailableSize> {
  AvailableSizeProvider() : super('AvailableSize');

  @override
  AvailableSize fromJson(data) {
    return AvailableSize.fromJson(data);
  }
}
