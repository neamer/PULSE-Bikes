// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'servicing_part.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ServicingPart _$ServicingPartFromJson(Map<String, dynamic> json) =>
    ServicingPart()
      ..id = json['id'] as int?
      ..servicingId = json['servicingId'] as int?
      ..productId = json['productId'] as int?
      ..unitPrice = (json['unitPrice'] as num?)?.toDouble()
      ..quantity = json['quantity'] as int?
      ..product = json['product'] == null
          ? null
          : Part.fromJson(json['product'] as Map<String, dynamic>);

Map<String, dynamic> _$ServicingPartToJson(ServicingPart instance) =>
    <String, dynamic>{
      'id': instance.id,
      'servicingId': instance.servicingId,
      'productId': instance.productId,
      'unitPrice': instance.unitPrice,
      'quantity': instance.quantity,
      'product': instance.product,
    };
