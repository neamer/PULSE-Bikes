import '../model/part/part.dart';
import 'base_provider.dart';

class PartProvider extends BaseProvider<Part> {
  PartProvider() : super("Part");

  @override
  Part fromJson(data) {
    return Part.fromJson(data);
  }
}
