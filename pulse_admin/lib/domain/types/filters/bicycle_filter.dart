import 'package:pulse_admin/api/types/brand/brand.dart';
import 'package:pulse_admin/api/types/product_category/product_category.dart';
import 'package:pulse_admin/domain/types/filters/abstract_filter.dart';

class BicycleFilter implements Filter {
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
      "IncludeImages": true,
      "AnyField": anyField,
      "BrandId": brand?.id,
      "ProductCategoryId": category?.id,
    };
  }
}