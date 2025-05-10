import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/abstract/base_model.dart';
import 'package:pulse_admin/api/types/generic/shipping_info.dart';
import 'package:pulse_admin/api/types/orders/order_detail.dart';
import 'package:pulse_admin/api/types/user/customer.dart';
import 'package:pulse_admin/api/types/user/staff.dart';

part 'order_header.g.dart';

enum OrderStatus {
  initial,
  cart,
  draft,
  processed,
  packed,
  shipped,
  collected,
  delivered,
  cancelled
}

extension Name on OrderStatus {
  String getName() {
    return "${name.substring(0, 1).toUpperCase()}${name.substring(1)}";
  }

  String getNameUppercase() {
    return name.toUpperCase();
  }
}

@JsonSerializable()
class OrderHeader extends BaseModel {
  String? orderNumber;
  int? customerId;
  int? staffId;
  int? paymentId;
  int? shippingInfoId;
  int? status;
  String? statusName;
  String? statusNamee;
  DateTime? timeProcessed;
  DateTime? timePacked;
  DateTime? timeShipped;
  DateTime? timeDelivered;
  bool? onlineOrder;
  bool? delivery;
  double? shippingConst;
  int? noOfItems;
  double? total;
  ShippingInfo? shippingInfo;
  Customer? customer;
  Staff? staff;

  List<OrderDetail> orderDetails = [];

  OrderHeader();

  factory OrderHeader.fromJson(Map<String, dynamic> json) =>
      _$OrderHeaderFromJson(json);

  Map<String, dynamic> toJson() => _$OrderHeaderToJson(this);

  double getTotal() {
    double result = 0;

    orderDetails.forEach((element) => result += element.total());

    return result;
  }
}
