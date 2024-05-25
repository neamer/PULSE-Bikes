import 'package:pulse_admin/api/providers/base/base_provider.dart';
import 'package:pulse_admin/api/types/user/customer.dart';

class CustomerProvider extends BaseProvider<Customer> {
  CustomerProvider() : super('Customer');

  @override
  Customer fromJson(data) {
    return Customer.fromJson(data);
  }
}
