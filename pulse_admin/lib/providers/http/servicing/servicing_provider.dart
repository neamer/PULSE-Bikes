import 'package:pulse_admin/data/servicing/servicing.dart';
import 'package:pulse_admin/providers/http/base/base_provider.dart';

class ServicingProvider extends BaseProvider<Servicing> {
  ServicingProvider() : super('Servicing');

  @override
  Servicing fromJson(data) {
    return Servicing.fromJson(data);
  }
}
