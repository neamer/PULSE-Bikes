import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:pulse_mobile/model/orders/order_header.dart';

Map<String, String> message = <String, String>{
  "PROCESSED":
      'Your order has been processed. Please wait unit it gets packed!',
  "PACKED": 'Your order has been packed and is waiting for shipment',
  "SHIPPED":
      'Your order has left the store and is on its way to the designated shipping location.',
  "DELIVERED": 'Order has been Delivered',
};

class OrderTracker extends StatelessWidget {
  final OrderHeader _order;

  const OrderTracker(this._order, {super.key});

  @override
  Widget build(BuildContext context) {
    var withDelivery = _order.delivery == true;
    return Column(
      children: [
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            IconButton(
                onPressed: () {},
                icon: _order.timeProcessed != null
                    ? const Icon(
                        Icons.check_circle,
                        color: Colors.white,
                      )
                    : const Icon(
                        Icons.check_circle_outline,
                        color: Colors.grey,
                      )),
            Expanded(child: Container(height: 2.0, color: Colors.grey)),
            if (withDelivery)
              IconButton(
                  onPressed: () {},
                  icon: _order.timePacked != null
                      ? const Icon(
                          Icons.check_circle,
                          color: Colors.green,
                        )
                      : const Icon(
                          Icons.check_circle_outline,
                          color: Colors.grey,
                        )),
            if (withDelivery)
              Expanded(child: Container(height: 2.0, color: Colors.grey)),
            if (withDelivery)
              IconButton(
                  onPressed: () {},
                  icon: _order.timeShipped != null
                      ? const Icon(
                          Icons.check_circle,
                          color: Colors.green,
                        )
                      : const Icon(
                          Icons.check_circle_outline,
                          color: Colors.grey,
                        )),
            Expanded(child: Container(height: 2.0, color: Colors.grey)),
            if (withDelivery)
              IconButton(
                  onPressed: () {},
                  icon: _order.timeDelivered != null
                      ? const Icon(
                          Icons.check_circle,
                          color: Colors.green,
                        )
                      : const Icon(
                          Icons.check_circle_outline,
                          color: Colors.grey,
                        ))
          ],
        ),
        Container(
          decoration: BoxDecoration(
              color: Theme.of(context).colorScheme.background,
              borderRadius: const BorderRadius.all(Radius.circular(7)),
              border: Border.all(color: const Color.fromRGBO(43, 43, 62, 1))),
          child: Padding(
            padding: const EdgeInsets.all(15),
            child: Column(children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text("ORDER ${_order.statusNamee}",
                      style: Theme.of(context)
                          .textTheme
                          .titleLarge
                          ?.copyWith(fontSize: 16)),
                  Text(DateFormat.yMMMEd().format(_order.timeProcessed!),
                      style: Theme.of(context)
                          .textTheme
                          .bodyLarge
                          ?.copyWith(fontSize: 15))
                ],
              ),
              const SizedBox(
                height: 15,
              ),
              Text(
                message[_order.statusNamee] ?? "",
                style: Theme.of(context).textTheme.bodyMedium,
                textAlign: TextAlign.justify,
              )
            ]),
          ),
        )
      ],
    );
  }
}
