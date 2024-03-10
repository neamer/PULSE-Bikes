import 'package:pulse_admin/core/abstract/abstract_filter.dart';
import 'package:pulse_admin/data/brand/brand.dart';
import 'package:pulse_admin/data/product_category/product_category.dart';

class GearFilter implements AbstractFilter {
  final bool includeBrand;
  final bool includeCategory;
  final bool includeSizes;
  String anyField = "";
  ProductCategory? category;
  Brand? brand;

  GearFilter(
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
