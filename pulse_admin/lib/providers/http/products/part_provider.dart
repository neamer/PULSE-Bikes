import 'package:pulse_admin/data/part/part.dart';
import 'package:pulse_admin/providers/http/base/base_crud_provider.dart';

class PartProvider extends BaseCRUDProvider<Part> {
  PartProvider() : super('Part');

  @override
  Part fromJson(data) {
    return Part.fromJson(data);
  }
}
