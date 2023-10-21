import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_mobile/model/abstract/base_model.dart';
import 'package:pulse_mobile/model/orders/order_detail.dart';

part 'order_header.g.dart';

@JsonSerializable()
class OrderHeader extends BaseModel {
  String? orderNumber;
  int? customerId;
  int? paymentId;
  int? shippingInfoId;
  int? status;
  String? statusName;
  DateTime? timeProcessed;
  DateTime? timePacked;
  DateTime? timeShipped;
  DateTime? timeDelivered;
  bool? onlineOrder;
  bool? delivery;
  double? shippingCost;
  int? noOfItems;
  double? total;

  List<OrderDetail> orderDetails = [];

  OrderHeader();

  factory OrderHeader.fromJson(Map<String, dynamic> json) =>
      _$OrderHeaderFromJson(json);

  Map<String, dynamic> toJson() => _$OrderHeaderToJson(this);
}
