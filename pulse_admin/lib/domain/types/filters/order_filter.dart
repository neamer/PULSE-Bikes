import 'package:pulse_admin/api/types/orders/order_header.dart';
import 'package:pulse_admin/domain/types/filters/abstract_filter.dart';

class OrderFilter implements Filter {
  final bool includePayment;
  final bool includeCustomer;
  final bool includeDetails;
  final bool includeShippingInfo;
  String anyField = "";
  OrderStatus? status;

  OrderFilter(
      {required this.includePayment,
      required this.includeCustomer,
      required this.includeDetails,
      required this.includeShippingInfo});

  @override
  Map<String, Object?> toQuery() {
    return {
      "IncludePayment": includePayment,
      "IncludeCustomer": includeCustomer,
      "IncludeDetails": includeDetails,
      "IncludeShippingInfo": includeShippingInfo,
      "AnyField": anyField,
      "Status": status?.index,
    };
  }
}
