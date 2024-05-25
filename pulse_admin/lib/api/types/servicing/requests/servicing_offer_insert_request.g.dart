// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'servicing_offer_insert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ServicingOfferInsertRequest _$ServicingOfferInsertRequestFromJson(
        Map<String, dynamic> json) =>
    ServicingOfferInsertRequest()
      ..id = json['id'] as int?
      ..offerDetails = json['offerDetails'] as String?
      ..labourCost = (json['labourCost'] as num?)?.toDouble()
      ..servicingParts = (json['servicingParts'] as List<dynamic>)
          .map((e) =>
              ServicingPartInsertRequest.fromJson(e as Map<String, dynamic>))
          .toList();

Map<String, dynamic> _$ServicingOfferInsertRequestToJson(
        ServicingOfferInsertRequest instance) =>
    <String, dynamic>{
      'id': instance.id,
      'offerDetails': instance.offerDetails,
      'labourCost': instance.labourCost,
      'servicingParts': instance.servicingParts,
    };
