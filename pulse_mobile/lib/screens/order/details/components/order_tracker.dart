import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'package:pulse_mobile/model/orders/order_header.dart';
import 'package:pulse_mobile/utils/util.dart';


var message = <OrderState, Object>{
  OrderState.Processed: 'Order has been processed',
  OrderState.Packed: 'Order has been Packed',
  OrderState.Shipped: 'Order has been Shipped',
  OrderState.Delivered: 'Order has been Delivered',
};

class OrderTracker extends StatelessWidget {
  final OrderHeader _order;

  OrderTracker(this._order, {super.key});


  @override
  Widget build(BuildContext context) {
    return Row(children: [

        Text("data"),
Icon(
          
          _order.timeProcessed != null ? Icons.check_circle : Icons.check_circle_outline
          
          ),

        IconButton(onPressed: () {}, icon: Icon(
          
          _order.timeProcessed != null ? Icons.check_circle : Icons.check_circle_outline
          
          ))
    ],);
  }

}