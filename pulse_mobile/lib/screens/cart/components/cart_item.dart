import 'package:flutter/material.dart';
import 'package:pulse_mobile/model/orders/order_detail.dart';
import 'package:pulse_mobile/model/product_type/product_type.dart';

class CartItem extends StatelessWidget {
  final OrderDetail item;
  final Function? onDelete;

  const CartItem(this.item, this.onDelete, {super.key});

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.only(bottom: 15),
      child: InkWell(
        child: Stack(clipBehavior: Clip.none, children: [
          Container(
              decoration: BoxDecoration(
                  color: Theme.of(context).colorScheme.background,
                  borderRadius: const BorderRadius.all(Radius.circular(7)),
                  border:
                      Border.all(color: const Color.fromRGBO(43, 43, 62, 1))),
              // margin: const EdgeInsets.only(top: 10, left: 10, right: 10),
              child: Row(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  ClipRRect(
                    borderRadius: const BorderRadius.only(
                        topLeft: Radius.circular(7),
                        bottomLeft: Radius.circular(7)),
                    child: Container(
                      height: 87,
                      width: 87,
                      color: Colors.grey.shade300,
                    ),
                  ),
                  Container(
                      padding: const EdgeInsets.all(10),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(
                            "${item.product?.brand?.name} · ${item.product?.model}",
                            style: Theme.of(context)
                                .textTheme
                                .titleLarge
                                ?.copyWith(fontSize: 18),
                          ),
                          const SizedBox(
                            height: 5,
                          ),
                          if (item.discriminator == ProductType.bicycle)
                            Column(
                              children: [
                                Text("Selected size: ${item.bicycleSize?.size}",
                                    style: Theme.of(context)
                                        .textTheme
                                        .bodyLarge
                                        ?.copyWith(fontSize: 14)),
                                const SizedBox(
                                  height: 7,
                                ),
                              ],
                            ),
                          Text(
                              "Category · ${item.product?.productCategory?.name}",
                              style: Theme.of(context)
                                  .textTheme
                                  .bodyLarge
                                  ?.copyWith(fontSize: 15)),
                          const SizedBox(
                            height: 7,
                          ),
                          Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            children: [
                              Text("\$${item.product?.price}",
                                  style: Theme.of(context)
                                      .textTheme
                                      .displayMedium
                                      ?.copyWith(fontSize: 14)),
                            ],
                          ),
                        ],
                      )),
                ],
              )),
              if(onDelete != null)
          Positioned(
              top: -20,
              right: -20,
              child: Container(
                child: IconButton(
                    onPressed: () => onDelete!(item.id),
                    icon: const Icon(
                      Icons.cancel,
                      color: Colors.red,
                    )),
              )),
          Positioned(
              bottom: 10,
              right: 10,
              child: Text(item.quantity.toString(),
                  style: Theme.of(context)
                      .textTheme
                      .displayMedium
                      ?.copyWith(fontSize: 14)))
        ]),
      ),
    );
  }
}
