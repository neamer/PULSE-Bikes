import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/servicing/servicing_part.dart';

part 'servicing_part_insert_request.g.dart';

@JsonSerializable()
class ServicingPartInsertRequest {
  int? productId;
  int? quantity;

  ServicingPartInsertRequest();

  factory ServicingPartInsertRequest.fromJson(Map<String, dynamic> json) =>
      _$ServicingPartInsertRequestFromJson(json);

  Map<String, dynamic> toJson() => _$ServicingPartInsertRequestToJson(this);

  ServicingPartInsertRequest.fromServicingPart(ServicingPart source) {
    productId = source.productId;
    quantity = source.quantity;
  }
}
