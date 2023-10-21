import 'package:flutter/material.dart';
import 'package:pulse_mobile/model/orders/order_detail.dart';
import 'package:pulse_mobile/model/product_type/product_type.dart';

class CartItem extends StatelessWidget {
  final OrderDetail item;

  const CartItem(this.item, {super.key});

  @override
  Widget build(BuildContext context) {
    return InkWell(
      child: Container(
          decoration: BoxDecoration(
              color: Theme.of(context).colorScheme.background,
              borderRadius: const BorderRadius.all(Radius.circular(7)),
              border: Border.all(color: const Color.fromRGBO(43, 43, 62, 1))),
          // margin: const EdgeInsets.only(top: 10, left: 10, right: 10),
          child: Row(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              ClipRRect(
                borderRadius: const BorderRadius.only(
                    topLeft: Radius.circular(7), topRight: Radius.circular(7)),
                child: Container(
                  height: 80,
                  color: Colors.grey.shade300,
                ),
              ),
              Container(
                  padding: const EdgeInsets.all(15),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        "${item.product.brand?.name} · ${item.product.model}",
                        style: Theme.of(context).textTheme.titleLarge,
                      ),
                      const SizedBox(
                        height: 5,
                      ),
                      if (item.discriminator == ProductType.bicycle)
                        Text("Selected size: ${item.bicycleSize?.size}",
                            style: Theme.of(context).textTheme.bodyLarge),
                      const SizedBox(
                        height: 5,
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Text(
                              "Category · ${item.product.productCategory?.name}",
                              style: Theme.of(context).textTheme.bodyLarge),
                          Text("\$${item.product.price}",
                              style: Theme.of(context).textTheme.displayMedium)
                        ],
                      ),
                    ],
                  ))
            ],
          )),
    );
  }
}
