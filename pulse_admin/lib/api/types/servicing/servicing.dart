import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/abstract/auditable_model.dart';
import 'package:pulse_admin/api/types/servicing/servicing_part.dart';
import 'package:pulse_admin/api/types/user/customer.dart';

part 'servicing.g.dart';

@JsonSerializable()
class Servicing extends AuditableModel {
  String? servicingNumber;
  int? customerId;
  int? paymentId;
  String? customerRequest;
  int? status;
  String? statusName;
  String? statusNamee;
  bool? onlinePayment;
  double? labourCost;
  String? offerDetails;
  Customer? customer;

  List<ServicingPart> servicingParts = [];

  Servicing();

  factory Servicing.fromJson(Map<String, dynamic> json) =>
      _$ServicingFromJson(json);

  Map<String, dynamic> toJson() => _$ServicingToJson(this);
}
