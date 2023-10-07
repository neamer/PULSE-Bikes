import 'package:pulse_mobile/model/part/part.dart';
import 'package:pulse_mobile/providers/abstract/base_crud_provider.dart';

class PartProvider extends BaseCRUDProvider<Part> {
  PartProvider() : super("Part");

  @override
  Part fromJson(data) {
    return Part.fromJson(data);
  }
}
