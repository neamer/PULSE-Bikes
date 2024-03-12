import 'package:pulse_admin/data/orders/order_header.dart';
import 'package:pulse_admin/providers/http/base/base_provider.dart';

class OrderProvider extends BaseProvider<OrderHeader> {
  OrderProvider() : super('Order');

  @override
  OrderHeader fromJson(data) {
    return OrderHeader.fromJson(data);
  }
}
