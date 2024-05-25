import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/brand/brand.dart';
import 'package:pulse_admin/api/types/product_category/product_category.dart';
import 'package:pulse_admin/domain/types/forms/bicycle_form_field_names.dart';

part 'bicycle_upsert_request.g.dart';

@JsonSerializable()
class BicycleUpsertRequest {
  String? productNumber;
  int? brandId;
  int? productCategoryId;
  String? model;
  String? description;
  double? price;
  double? weight;
  int? productionYear;
  String? wheelSize;

  BicycleUpsertRequest();

  factory BicycleUpsertRequest.fromJson(Map<String, dynamic> json) =>
      _$BicycleUpsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$BicycleUpsertRequestToJson(this);

  BicycleUpsertRequest.fromFormData(Map<String, dynamic> formData) {
    productNumber = formData[BicycleFormFieldNames.productNumber];
    brandId = (formData[BicycleFormFieldNames.brand] as Brand).id;
    productCategoryId =
        (formData[BicycleFormFieldNames.category] as ProductCategory).id;
    model = formData[BicycleFormFieldNames.model];
    description = formData[BicycleFormFieldNames.description];
    price = formData[BicycleFormFieldNames.price];
    weight = formData[BicycleFormFieldNames.weight];
    productionYear = formData[BicycleFormFieldNames.productionYear];
    wheelSize = formData[BicycleFormFieldNames.wheelSize];
  }
}
