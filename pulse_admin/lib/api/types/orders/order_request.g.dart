// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

OrderRequest _$OrderRequestFromJson(Map<String, dynamic> json) => OrderRequest()
  ..shippingInfo = json['shippingInfo'] == null
      ? null
      : ShippingInfo.fromJson(json['shippingInfo'] as Map<String, dynamic>);

Map<String, dynamic> _$OrderRequestToJson(OrderRequest instance) =>
    <String, dynamic>{
      'shippingInfo': instance.shippingInfo,
    };
