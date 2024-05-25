import 'package:pulse_admin/api/providers/base/base_crud_provider.dart';
import 'package:pulse_admin/api/types/part/part.dart';

class PartProvider extends BaseCRUDProvider<Part> {
  PartProvider() : super('Part');

  @override
  Part fromJson(data) {
    return Part.fromJson(data);
  }
}
