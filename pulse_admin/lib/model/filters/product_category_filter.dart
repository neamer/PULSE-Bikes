import 'package:pulse_admin/core/abstract/abstract_filter.dart';

class ProductCategoryFilter implements AbstractFilter {
  String anyField = "";

  ProductCategoryFilter();

  @override
  Map<String, Object?> toQuery() {
    return {
      "AnyField": anyField,
    };
  }
}
