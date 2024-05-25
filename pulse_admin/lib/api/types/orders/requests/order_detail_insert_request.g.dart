// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_detail_insert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

OrderDetailInsertRequest _$OrderDetailInsertRequestFromJson(
        Map<String, dynamic> json) =>
    OrderDetailInsertRequest()
      ..productId = json['productId'] as int?
      ..quantity = json['quantity'] as int?
      ..bicycleSizeId = json['bicycleSizeId'] as int?
      ..discriminator = json['discriminator'] as String?;

Map<String, dynamic> _$OrderDetailInsertRequestToJson(
        OrderDetailInsertRequest instance) =>
    <String, dynamic>{
      'productId': instance.productId,
      'quantity': instance.quantity,
      'bicycleSizeId': instance.bicycleSizeId,
      'discriminator': instance.discriminator,
    };
