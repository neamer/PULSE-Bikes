import '../model/part/part.dart';
import 'base_crud_provider.dart';

class PartProvider extends BaseCRUDProvider<Part> {
  PartProvider() : super("Part");

  @override
  Part fromJson(data) {
    return Part.fromJson(data);
  }
}
