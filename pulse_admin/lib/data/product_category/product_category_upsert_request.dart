import 'package:json_annotation/json_annotation.dart';

part 'product_category_upsert_request.g.dart';

abstract class ProductCategoryUpsertRequestFieldNames {
  static const String name = "name";
}

@JsonSerializable()
class ProductCategoryUpsertRequest {
  String? name;

  ProductCategoryUpsertRequest();

  factory ProductCategoryUpsertRequest.fromJson(Map<String, dynamic> json) =>
      _$ProductCategoryUpsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$ProductCategoryUpsertRequestToJson(this);

  ProductCategoryUpsertRequest.fromFormData(Map<String, dynamic> formData) {
    name = formData[ProductCategoryUpsertRequestFieldNames.name];
  }
}
