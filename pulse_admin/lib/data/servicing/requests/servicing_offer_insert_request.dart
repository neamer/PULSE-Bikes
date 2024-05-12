import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/data/abstract/base_model.dart';
import 'package:pulse_admin/data/servicing/requests/servicing_part_insert_request.dart';
import 'package:pulse_admin/data/servicing/servicing_part.dart';
import 'package:pulse_admin/model/forms/servicing_offer_form_fields.dart';

part 'servicing_offer_insert_request.g.dart';

@JsonSerializable()
class ServicingOfferInsertRequest extends BaseModel {
  String? offerDetails;
  double? labourCost;
  List<ServicingPartInsertRequest> servicingParts = [];

  ServicingOfferInsertRequest();

  factory ServicingOfferInsertRequest.fromJson(Map<String, dynamic> json) =>
      _$ServicingOfferInsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$ServicingOfferInsertRequestToJson(this);

  ServicingOfferInsertRequest.fromFormData(Map<String, dynamic> formData) {
    offerDetails = formData[ServicingOfferFormFields.offerDetails];
    labourCost = formData[ServicingOfferFormFields.labourCost];

    servicingParts = (formData[ServicingOfferFormFields.servicingParts]
            as List<ServicingPart>)
        .map((e) => ServicingPartInsertRequest.fromServicingPart(e))
        .toList();
  }
}
