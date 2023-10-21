// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_detail_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

OrderDetailRequest _$OrderDetailRequestFromJson(Map<String, dynamic> json) =>
    OrderDetailRequest()
      ..productId = json['productId'] as int?
      ..quantity = json['quantity'] as int?
      ..bicycleSizeId = json['bicycleSizeId'] as int?;

Map<String, dynamic> _$OrderDetailRequestToJson(OrderDetailRequest instance) =>
    <String, dynamic>{
      'productId': instance.productId,
      'quantity': instance.quantity,
      'bicycleSizeId': instance.bicycleSizeId,
    };
