// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'servicing.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Servicing _$ServicingFromJson(Map<String, dynamic> json) => Servicing()
  ..id = json['id'] as int?
  ..createdAt = json['createdAt'] == null
      ? null
      : DateTime.parse(json['createdAt'] as String)
  ..updatedAt = json['updatedAt'] == null
      ? null
      : DateTime.parse(json['updatedAt'] as String)
  ..servicingNumber = json['servicingNumber'] as String?
  ..customerId = json['customerId'] as int?
  ..paymentId = json['paymentId'] as int?
  ..customerRequest = json['customerRequest'] as String?
  ..status = json['status'] as int?
  ..statusName = json['statusName'] as String?
  ..statusNamee = json['statusNamee'] as String?
  ..onlinePayment = json['onlinePayment'] as bool?
  ..labourCost = (json['labourCost'] as num?)?.toDouble()
  ..offerDetails = json['offerDetails'] as String?
  ..customer = json['customer'] == null
      ? null
      : Customer.fromJson(json['customer'] as Map<String, dynamic>)
  ..servicingParts = (json['servicingParts'] as List<dynamic>)
      .map((e) => ServicingPart.fromJson(e as Map<String, dynamic>))
      .toList();

Map<String, dynamic> _$ServicingToJson(Servicing instance) => <String, dynamic>{
      'id': instance.id,
      'createdAt': instance.createdAt?.toIso8601String(),
      'updatedAt': instance.updatedAt?.toIso8601String(),
      'servicingNumber': instance.servicingNumber,
      'customerId': instance.customerId,
      'paymentId': instance.paymentId,
      'customerRequest': instance.customerRequest,
      'status': instance.status,
      'statusName': instance.statusName,
      'statusNamee': instance.statusNamee,
      'onlinePayment': instance.onlinePayment,
      'labourCost': instance.labourCost,
      'offerDetails': instance.offerDetails,
      'customer': instance.customer,
      'servicingParts': instance.servicingParts,
    };
