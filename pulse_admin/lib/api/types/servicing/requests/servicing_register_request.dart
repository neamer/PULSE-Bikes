import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/user/customer.dart';
import 'package:pulse_admin/domain/types/forms/servicing_register_form_field_names.dart';

part 'servicing_register_request.g.dart';

@JsonSerializable()
class ServicingRegisterRequest {
  int? customerId;
  String? customerRequest;

  ServicingRegisterRequest();

  factory ServicingRegisterRequest.fromJson(Map<String, dynamic> json) =>
      _$ServicingRegisterRequestFromJson(json);

  Map<String, dynamic> toJson() => _$ServicingRegisterRequestToJson(this);

  ServicingRegisterRequest.fromFormData(Map<String, dynamic> formData) {
    customerId =
        (formData[ServicingRegisterFormFieldNames.customer] as Customer).id;
    customerRequest = formData[ServicingRegisterFormFieldNames.request];
  }
}
