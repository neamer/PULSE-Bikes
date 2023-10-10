// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_detail.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

OrderDetail _$OrderDetailFromJson(Map<String, dynamic> json) => OrderDetail()
  ..productId = json['productId'] as int?
  ..quantity = json['quantity'] as int?
  ..bicycleSizeId = json['bicycleSizeId'] as int?;

Map<String, dynamic> _$OrderDetailToJson(OrderDetail instance) =>
    <String, dynamic>{
      'productId': instance.productId,
      'quantity': instance.quantity,
      'bicycleSizeId': instance.bicycleSizeId,
    };
