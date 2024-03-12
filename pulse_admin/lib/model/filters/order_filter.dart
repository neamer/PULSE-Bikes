import 'package:pulse_admin/data/orders/order_header.dart';
import 'package:pulse_admin/model/filters/abstract_filter.dart';

class OrderFilter implements Filter {
  final bool includePayment;
  final bool includeCustomer;
  final bool includeDetails;
  String anyField = "";
  OrderStatus? status;

  OrderFilter(
      {required this.includePayment,
      required this.includeCustomer,
      required this.includeDetails});

  @override
  Map<String, Object?> toQuery() {
    return {
      "IncludePayment": includePayment,
      "IncludeCustomer": includeCustomer,
      "IncludeDetails": includeDetails,
      "AnyField": anyField,
      "Status": status?.index,
    };
  }
}
