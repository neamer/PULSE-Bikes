// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'servicing_part_insert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ServicingPartInsertRequest _$ServicingPartInsertRequestFromJson(
        Map<String, dynamic> json) =>
    ServicingPartInsertRequest()
      ..productId = json['productId'] as int?
      ..quantity = json['quantity'] as int?;

Map<String, dynamic> _$ServicingPartInsertRequestToJson(
        ServicingPartInsertRequest instance) =>
    <String, dynamic>{
      'productId': instance.productId,
      'quantity': instance.quantity,
    };
