import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/data/bicycle_size/bicycle_size.dart';
import 'package:pulse_admin/model/forms/available_size_form_field_names.dart';

part 'available_size_insert_request.g.dart';

@JsonSerializable()
class AvailableSizeInsertRequest {
  int? productId;
  int? bicycleSizeId;
  int? availableQty;

  AvailableSizeInsertRequest();

  factory AvailableSizeInsertRequest.fromJson(Map<String, dynamic> json) =>
      _$AvailableSizeInsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$AvailableSizeInsertRequestToJson(this);

  AvailableSizeInsertRequest.fromFormData(
      int this.productId, Map<String, dynamic> formData) {
    bicycleSizeId =
        (formData[AvailableSizeFormFieldNames.bicycleSize] as BicycleSize).id;
    availableQty = formData[AvailableSizeFormFieldNames.availableQty];
  }
}
