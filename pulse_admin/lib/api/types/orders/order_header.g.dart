// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_header.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

OrderHeader _$OrderHeaderFromJson(Map<String, dynamic> json) => OrderHeader()
  ..id = json['id'] as int?
  ..orderNumber = json['orderNumber'] as String?
  ..customerId = json['customerId'] as int?
  ..staffId = json['staffId'] as int?
  ..paymentId = json['paymentId'] as int?
  ..shippingInfoId = json['shippingInfoId'] as int?
  ..status = json['status'] as int?
  ..statusName = json['statusName'] as String?
  ..statusNamee = json['statusNamee'] as String?
  ..timeProcessed = json['timeProcessed'] == null
      ? null
      : DateTime.parse(json['timeProcessed'] as String)
  ..timePacked = json['timePacked'] == null
      ? null
      : DateTime.parse(json['timePacked'] as String)
  ..timeShipped = json['timeShipped'] == null
      ? null
      : DateTime.parse(json['timeShipped'] as String)
  ..timeDelivered = json['timeDelivered'] == null
      ? null
      : DateTime.parse(json['timeDelivered'] as String)
  ..onlineOrder = json['onlineOrder'] as bool?
  ..delivery = json['delivery'] as bool?
  ..shippingConst = (json['shippingConst'] as num?)?.toDouble()
  ..noOfItems = json['noOfItems'] as int?
  ..total = (json['total'] as num?)?.toDouble()
  ..shippingInfo = json['shippingInfo'] == null
      ? null
      : ShippingInfo.fromJson(json['shippingInfo'] as Map<String, dynamic>)
  ..customer = json['customer'] == null
      ? null
      : Customer.fromJson(json['customer'] as Map<String, dynamic>)
  ..staff = json['staff'] == null
      ? null
      : Staff.fromJson(json['staff'] as Map<String, dynamic>)
  ..orderDetails = (json['orderDetails'] as List<dynamic>)
      .map((e) => OrderDetail.fromJson(e as Map<String, dynamic>))
      .toList();

Map<String, dynamic> _$OrderHeaderToJson(OrderHeader instance) =>
    <String, dynamic>{
      'id': instance.id,
      'orderNumber': instance.orderNumber,
      'customerId': instance.customerId,
      'staffId': instance.staffId,
      'paymentId': instance.paymentId,
      'shippingInfoId': instance.shippingInfoId,
      'status': instance.status,
      'statusName': instance.statusName,
      'statusNamee': instance.statusNamee,
      'timeProcessed': instance.timeProcessed?.toIso8601String(),
      'timePacked': instance.timePacked?.toIso8601String(),
      'timeShipped': instance.timeShipped?.toIso8601String(),
      'timeDelivered': instance.timeDelivered?.toIso8601String(),
      'onlineOrder': instance.onlineOrder,
      'delivery': instance.delivery,
      'shippingConst': instance.shippingConst,
      'noOfItems': instance.noOfItems,
      'total': instance.total,
      'shippingInfo': instance.shippingInfo,
      'customer': instance.customer,
      'staff': instance.staff,
      'orderDetails': instance.orderDetails,
    };
