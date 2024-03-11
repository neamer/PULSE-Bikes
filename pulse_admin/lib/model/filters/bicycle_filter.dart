import 'package:pulse_admin/model/filters/abstract_filter.dart';
import 'package:pulse_admin/data/brand/brand.dart';
import 'package:pulse_admin/data/product_category/product_category.dart';

class BicycleFilter implements AbstractFilter {
  final bool includeBrand;
  final bool includeCategory;
  final bool includeSizes;
  String anyField = "";
  ProductCategory? category;
  Brand? brand;

  BicycleFilter(
      {required this.includeBrand,
      required this.includeCategory,
      required this.includeSizes});

  @override
  Map<String, Object?> toQuery() {
    return {
      "IncludeBrand": true,
      "IncludeCategory": true,
      "IncludeSizes": true,
      "AnyField": anyField,
      "BrandId": brand?.id,
      "ProductCategoryId": category?.id,
    };
  }
}
