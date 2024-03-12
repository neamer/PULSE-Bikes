import 'package:pulse_admin/model/filters/abstract_filter.dart';

class BasicFilter implements Filter {
  String anyField = "";

  BasicFilter();

  @override
  Map<String, Object?> toQuery() {
    return {
      "Name": anyField,
    };
  }
}
