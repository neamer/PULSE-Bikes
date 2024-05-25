// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'servicing_register_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ServicingRegisterRequest _$ServicingRegisterRequestFromJson(
        Map<String, dynamic> json) =>
    ServicingRegisterRequest()
      ..customerId = json['customerId'] as int?
      ..customerRequest = json['customerRequest'] as String?;

Map<String, dynamic> _$ServicingRegisterRequestToJson(
        ServicingRegisterRequest instance) =>
    <String, dynamic>{
      'customerId': instance.customerId,
      'customerRequest': instance.customerRequest,
    };
