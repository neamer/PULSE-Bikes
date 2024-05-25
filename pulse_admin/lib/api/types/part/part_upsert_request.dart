import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/brand/brand.dart';
import 'package:pulse_admin/api/types/product_category/product_category.dart';
import 'package:pulse_admin/domain/types/forms/part_form_field_names.dart';

part 'part_upsert_request.g.dart';

@JsonSerializable()
class PartUpsertRequest {
  String? productNumber;
  int? brandId;
  int? productCategoryId;
  String? model;
  String? description;
  double? price;
  int? availableQty;

  PartUpsertRequest();

  factory PartUpsertRequest.fromJson(Map<String, dynamic> json) =>
      _$PartUpsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$PartUpsertRequestToJson(this);

  PartUpsertRequest.fromFormData(Map<String, dynamic> formData) {
    productNumber = formData[PartFormFieldNames.productNumber];
    brandId = (formData[PartFormFieldNames.brand] as Brand).id;
    productCategoryId =
        (formData[PartFormFieldNames.category] as ProductCategory).id;
    model = formData[PartFormFieldNames.model];
    description = formData[PartFormFieldNames.description];
    price = formData[PartFormFieldNames.price];
    availableQty = formData[PartFormFieldNames.availableQty];
  }
}
