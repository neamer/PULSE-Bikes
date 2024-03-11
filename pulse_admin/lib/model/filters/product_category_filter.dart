import 'package:pulse_admin/model/filters/abstract_filter.dart';

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
