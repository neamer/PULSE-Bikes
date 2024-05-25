import 'package:pulse_admin/api/types/servicing/servicing_status.dart';
import 'package:pulse_admin/domain/types/filters/abstract_filter.dart';

class ServicingFilter implements Filter {
  final bool includePayment;
  final bool includeCustomer;
  final bool includeParts;
  String anyField = "";
  ServicingStatus? status;

  ServicingFilter(
      {required this.includePayment,
      required this.includeCustomer,
      required this.includeParts});

  @override
  Map<String, Object?> toQuery() {
    return {
      "IncludePayment": includePayment,
      "IncludeCustomer": includeCustomer,
      "IncludeParts": includeParts,
      "AnyField": anyField,
      "Status": status?.index,
    };
  }
}
