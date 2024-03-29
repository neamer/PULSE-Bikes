import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_mobile/model/abstract/base_model.dart';
import 'package:pulse_mobile/model/servicing/servicing_part.dart';

part 'servicing.g.dart';

@JsonSerializable()
class Servicing extends BaseModel {
  String? servicingNumber;
  int? customerId;
  int? paymentId;
  String? customerRequest;
  int? status;
  String? statusName;
  bool? onlinePayment;
  double? labourCost;
  String? offerDetails;

  List<ServicingPart> servicingParts = [];

  Servicing();

  factory Servicing.fromJson(Map<String, dynamic> json) =>
      _$ServicingFromJson(json);

  Map<String, dynamic> toJson() => _$ServicingToJson(this);
}
