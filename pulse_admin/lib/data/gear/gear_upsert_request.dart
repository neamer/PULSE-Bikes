import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/data/brand/brand.dart';
import 'package:pulse_admin/data/product_category/product_category.dart';
import 'package:pulse_admin/model/forms/gear_form_field_names.dart';

part 'gear_upsert_request.g.dart';

@JsonSerializable()
class GearUpsertRequest {
  String? productNumber;
  int? brandId;
  int? productCategoryId;
  String? model;
  String? description;
  double? price;
  int? availableQty;

  GearUpsertRequest();

  factory GearUpsertRequest.fromJson(Map<String, dynamic> json) =>
      _$GearUpsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$GearUpsertRequestToJson(this);

  GearUpsertRequest.fromFormData(Map<String, dynamic> formData) {
    productNumber = formData[GearFormFieldNames.productNumber];
    brandId = (formData[GearFormFieldNames.brand] as Brand).id;
    productCategoryId =
        (formData[GearFormFieldNames.category] as ProductCategory).id;
    model = formData[GearFormFieldNames.model];
    description = formData[GearFormFieldNames.description];
    price = formData[GearFormFieldNames.price];
    availableQty = formData[GearFormFieldNames.availableQty];
  }
}
