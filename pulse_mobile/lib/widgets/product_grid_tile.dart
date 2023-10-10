import 'package:flutter/material.dart';

import '../model/abstract/product.dart';

class ProductGridTile extends StatelessWidget {
  final Product _product;
  final Function(int?)? onTap;

  const ProductGridTile(this._product, {super.key, this.onTap});

  @override
  Widget build(BuildContext context) {
    return InkWell(
      onTap: () => onTap!(_product.id),
      child: Container(
          decoration: BoxDecoration(
              color: Theme.of(context).colorScheme.background,
              borderRadius: const BorderRadius.all(Radius.circular(7)),
              border: Border.all(color: const Color.fromRGBO(43, 43, 62, 1))),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              ClipRRect(
                borderRadius: const BorderRadius.only(
                    topLeft: Radius.circular(7), topRight: Radius.circular(7)),
                child: Container(
                  height: 120,
                  color: Colors.grey.shade300,
                ),
              ),
              Container(
                  padding: const EdgeInsets.all(15),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        "${_product.brand?.name}",
                        style: Theme.of(context)
                            .textTheme
                            .titleLarge
                            ?.copyWith(fontSize: 18),
                      ),
                      const SizedBox(
                        height: 5,
                      ),
                      SingleChildScrollView(
                        physics: const BouncingScrollPhysics(),
                        scrollDirection: Axis.horizontal,
                        child: SizedBox(
                          height: 20,
                          child: Text(
                            "${_product.model}",
                            maxLines: 1,
                            style: Theme.of(context)
                                .textTheme
                                .titleLarge
                                ?.copyWith(fontSize: 18),
                          ),
                        ),
                      ),
                      // SizedBox(
                      //   height: 5,
                      // ),
                      // Text("Available Sizes",
                      //     style: Theme.of(context).textTheme.bodyText1),
                      const SizedBox(
                        height: 5,
                      ),
                      Text("${_product.productCategory?.name}",
                          style: Theme.of(context)
                              .textTheme
                              .bodyLarge
                              ?.copyWith(fontSize: 16)),
                      const SizedBox(
                        height: 5,
                      ),
                      Text("\$${_product.price}",
                          style: Theme.of(context)
                              .textTheme
                              .displayMedium
                              ?.copyWith(fontSize: 16))
                    ],
                  ))
            ],
          )),
    );
  }
}
