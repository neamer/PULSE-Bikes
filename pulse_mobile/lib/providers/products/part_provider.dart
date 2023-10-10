import 'package:pulse_mobile/model/part/part.dart';
import 'package:pulse_mobile/providers/abstract/product_provider.dart';

class PartProvider extends ProductProvider<Part> {
  PartProvider() : super("Part");

  @override
  Part fromJson(data) {
    return Part.fromJson(data);
  }
}
