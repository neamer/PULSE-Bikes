// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'payment_insert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

PaymentInsertRequest _$PaymentInsertRequestFromJson(
        Map<String, dynamic> json) =>
    PaymentInsertRequest()
      ..method = json['method'] as String?
      ..paymentId = json['paymentId'] as String?;

Map<String, dynamic> _$PaymentInsertRequestToJson(
        PaymentInsertRequest instance) =>
    <String, dynamic>{
      'method': instance.method,
      'paymentId': instance.paymentId,
    };
