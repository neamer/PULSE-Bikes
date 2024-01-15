import 'dart:convert';
import 'dart:typed_data';
import 'package:flutter/widgets.dart';
import 'package:intl/intl.dart';

class Authorization {
  static String? username;
  static String? password;
}

Image imageFromBase64String(String base64String) {
  return Image.memory(base64Decode(base64String));
}

Uint8List dataFromBase64String(String base64String) {
  return base64Decode(base64String);
}

String base64String(Uint8List data) {
  return base64Encode(data);
}

String formatNumber(dynamic) {
  var f = NumberFormat('###,00');
  if (dynamic == null) {
    return "";
  }

  return f.format(dynamic);
}

enum OrderState {
  Initial,
  Cart,
  Draft,
  Processed,
  Packed,
  Shipped,
  Collected,
  Delivered,
  Cancelled
}

String GetStateName(OrderState state) {
  switch (state) {
    case OrderState.Initial:
      return "INITIAL";
      break;
    case OrderState.Cart:
      return "CART";
      break;
    case OrderState.Draft:
      return "DRAFT";
      break;
    case OrderState.Processed:
      return "PROCESSED";
      break;
    case OrderState.Packed:
      return "PACKED";
      break;
    case OrderState.Shipped:
      return "SHIPPED";
      break;
    case OrderState.Collected:
      return "COLLECTED";
      break;
    case OrderState.Delivered:
      return "DELIVERED";
      break;
    case OrderState.Cancelled:
      return "CANCELLED";
      break;
    default:
      return "";
      break;
  }
}

enum ServicingState {
  Initial,
  PendingReview,
  PendingPayment,
  PendingServicing,
  Cancelled
}

String GetServicingStateName(ServicingState state) {
  switch (state) {
    case ServicingState.Initial:
      return "INITIAL";
      break;
    case ServicingState.PendingReview:
      return "PENDING REVIEW";
      break;
    case ServicingState.PendingPayment:
      return "PENDING PAYMENT";
      break;
    case ServicingState.PendingServicing:
      return "PENDING SERVICING";
      break;
    case ServicingState.Cancelled:
      return "CANCELLED";
      break;
    default:
      return "";
  }
}
