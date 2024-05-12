import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/data/orders/order_header.dart';

Map<String, String> messageWithoutDelivery = <String, String>{
  "DRAFT": "Order is in draft state",
  "PROCESSED": 'This order has been processed!',
};

Map<String, String> messageWithDelivery = <String, String>{
  "DRAFT": "Order is in draft state",
  "PROCESSED":
      'This order has been processed. Please wait unit it gets packed before proceeding!',
  "PACKED": 'This order has been packed and is waiting for shipment',
  "SHIPPED":
      'This order has left the store and is on its way to the designated shipping location.',
  "DELIVERED": 'Order has been delivered to the customer',
};

class OrderTracker extends StatelessWidget {
  final OrderHeader _order;

  const OrderTracker(this._order, {super.key});

  @override
  Widget build(BuildContext context) {
    DateTime? latestDate;
    var withDelivery = _order.delivery == true;

    if (_order.timeDelivered != null) {
      latestDate = _order.timeDelivered;
    } else if (_order.timeShipped != null) {
      latestDate = _order.timeShipped;
    } else if (_order.timePacked != null) {
      latestDate = _order.timePacked;
    } else if (_order.timeProcessed != null) {
      latestDate = _order.timeProcessed;
    }

    return SpacedColumn(
      spacing: Spacing.md,
      children: [
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Tooltip(
              message: "Draft",
              child: IconButton(
                  onPressed: () {},
                  icon: const Icon(
                    Icons.check_circle,
                    color: Colors.green,
                  )),
            ),
            Expanded(child: Container(height: 2.0, color: Colors.grey)),
            Tooltip(
              message: "Processed",
              child: IconButton(
                  onPressed: () {},
                  icon: _order.timeProcessed != null
                      ? const Icon(
                          Icons.check_circle,
                          color: Colors.green,
                        )
                      : const Icon(
                          Icons.check_circle_outline,
                          color: Colors.grey,
                        )),
            ),
            if (withDelivery)
              Expanded(child: Container(height: 2.0, color: Colors.grey)),
            if (withDelivery)
              Tooltip(
                message: "Packed",
                child: IconButton(
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
              ),
            if (withDelivery)
              Expanded(child: Container(height: 2.0, color: Colors.grey)),
            if (withDelivery)
              Tooltip(
                message: "Shipped",
                child: IconButton(
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
              ),
            if (withDelivery)
              Expanded(child: Container(height: 2.0, color: Colors.grey)),
            if (withDelivery)
              Tooltip(
                message: "Delivered",
                child: IconButton(
                    onPressed: () {},
                    icon: _order.timeDelivered != null
                        ? const Icon(
                            Icons.check_circle,
                            color: Colors.green,
                          )
                        : const Icon(
                            Icons.check_circle_outline,
                            color: Colors.grey,
                          )),
              )
          ],
        ),
        Container(
          decoration: BoxDecoration(
              color: Theme.of(context).colorScheme.background,
              borderRadius: BorderRadius.circular(Radius.sm),
              border: Border.all(color: const Color.fromRGBO(43, 43, 62, 1))),
          child: Padding(
            padding: const EdgeInsets.all(15),
            child:
                Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text(
                      "ORDER ${OrderStatus.values[_order.status!].getNameUppercase()}",
                      style: Theme.of(context)
                          .textTheme
                          .titleLarge
                          ?.copyWith(fontSize: 16)),
                  Text(
                      latestDate != null
                          ? DateFormat.yMMMEd().format(latestDate)
                          : "",
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
                (_order.delivery == true
                        ? messageWithDelivery[OrderStatus.values[_order.status!]
                            .getNameUppercase()]
                        : messageWithoutDelivery[OrderStatus
                            .values[_order.status!]
                            .getNameUppercase()]) ??
                    "",
                style: Theme.of(context).textTheme.bodyMedium,
                textAlign: TextAlign.left,
              )
            ]),
          ),
        )
      ],
    );
  }
}
