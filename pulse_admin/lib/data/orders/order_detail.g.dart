// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_detail.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

OrderDetail _$OrderDetailFromJson(Map<String, dynamic> json) => OrderDetail()
  ..id = json['id'] as int?
  ..productId = json['productId'] as int?
  ..quantity = json['quantity'] as int?
  ..bicycleSizeId = json['bicycleSizeId'] as int?
  ..unitPrice = (json['unitPrice'] as num?)?.toDouble()
  ..discriminator = json['discriminator'] as String?
  ..bicycleSize = json['bicycleSize'] == null
      ? null
      : BicycleSize.fromJson(json['bicycleSize'] as Map<String, dynamic>)
  ..product = json['product'] == null
      ? null
      : Product.fromJson(json['product'] as Map<String, dynamic>);

Map<String, dynamic> _$OrderDetailToJson(OrderDetail instance) =>
    <String, dynamic>{
      'id': instance.id,
      'productId': instance.productId,
      'quantity': instance.quantity,
      'bicycleSizeId': instance.bicycleSizeId,
      'unitPrice': instance.unitPrice,
      'discriminator': instance.discriminator,
      'bicycleSize': instance.bicycleSize,
      'product': instance.product,
    };
