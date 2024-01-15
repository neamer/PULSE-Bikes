// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'servicing.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Servicing _$ServicingFromJson(Map<String, dynamic> json) => Servicing()
  ..id = json['id'] as int?
  ..servicingNumber = json['servicingNumber'] as String?
  ..customerId = json['customerId'] as int?
  ..paymentId = json['paymentId'] as int?
  ..customerRequest = json['customerRequest'] as String?
  ..status = json['status'] as int?
  ..statusName = json['statusName'] as String?
  ..onlinePayment = json['onlinePayment'] as bool?
  ..labourCost = (json['labourCost'] as num?)?.toDouble()
  ..offerDetails = json['offerDetails'] as String?
  ..servicingParts = (json['servicingParts'] as List<dynamic>)
      .map((e) => ServicingPart.fromJson(e as Map<String, dynamic>))
      .toList();

Map<String, dynamic> _$ServicingToJson(Servicing instance) => <String, dynamic>{
      'id': instance.id,
      'servicingNumber': instance.servicingNumber,
      'customerId': instance.customerId,
      'paymentId': instance.paymentId,
      'customerRequest': instance.customerRequest,
      'status': instance.status,
      'statusName': instance.statusName,
      'onlinePayment': instance.onlinePayment,
      'labourCost': instance.labourCost,
      'offerDetails': instance.offerDetails,
      'servicingParts': instance.servicingParts,
    };
