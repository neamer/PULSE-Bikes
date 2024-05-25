// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_header_insert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

OrderHeaderInsertRequest _$OrderHeaderInsertRequestFromJson(
        Map<String, dynamic> json) =>
    OrderHeaderInsertRequest()
      ..id = json['id'] as int?
      ..orderNumber = json['orderNumber'] as String?
      ..customerId = json['customerId'] as int?
      ..onlineOrder = json['onlineOrder'] as bool?
      ..delivery = json['delivery'] as bool?
      ..shippingConst = (json['shippingConst'] as num?)?.toDouble()
      ..shippingInfo = json['shippingInfo'] == null
          ? null
          : ShippingInfo.fromJson(json['shippingInfo'] as Map<String, dynamic>)
      ..orderDetails = (json['orderDetails'] as List<dynamic>)
          .map((e) =>
              OrderDetailInsertRequest.fromJson(e as Map<String, dynamic>))
          .toList();

Map<String, dynamic> _$OrderHeaderInsertRequestToJson(
        OrderHeaderInsertRequest instance) =>
    <String, dynamic>{
      'id': instance.id,
      'orderNumber': instance.orderNumber,
      'customerId': instance.customerId,
      'onlineOrder': instance.onlineOrder,
      'delivery': instance.delivery,
      'shippingConst': instance.shippingConst,
      'shippingInfo': instance.shippingInfo,
      'orderDetails': instance.orderDetails,
    };
