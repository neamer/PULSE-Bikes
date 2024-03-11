import 'package:pulse_admin/data/part/part.dart';
import 'package:pulse_admin/providers/http/base/base_provider.dart';

class PartProvider extends BaseProvider<Part> {
  PartProvider() : super('Part');

  @override
  Part fromJson(data) {
    return Part.fromJson(data);
  }
}
