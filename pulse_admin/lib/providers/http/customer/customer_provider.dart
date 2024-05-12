import 'package:pulse_admin/data/user/customer.dart';
import 'package:pulse_admin/providers/http/base/base_provider.dart';

class CustomerProvider extends BaseProvider<Customer> {
  CustomerProvider() : super('Customer');

  @override
  Customer fromJson(data) {
    return Customer.fromJson(data);
  }
}
