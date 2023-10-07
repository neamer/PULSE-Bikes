import 'package:flutter/material.dart';
import 'package:pulse_mobile/model/available_size/available_size.dart';
import 'package:pulse_mobile/model/bicycle/bicycle.dart';

import '../model/gear/gear.dart';
import '../model/part/part.dart';
import '../model/abstract/product.dart';

class ProductListTile<T extends Product> extends StatelessWidget {
  final T _product;
  final Function(int?)? onTap;

  const ProductListTile(this._product, {super.key, this.onTap});

  String _formatAvailableSizes() {
    var bicycle = _product as Bicycle;
    var output = "";

    for (var size in bicycle.availableSizes ?? <AvailableSize>[]) {
      output += size.bicycleSize?.size ?? "";
    }

    return output;
  }

  @override
  Widget build(BuildContext context) {
    return InkWell(
      onTap: () => this.onTap!(_product.id),
      child: Container(
          decoration: BoxDecoration(
              color: Theme.of(context).backgroundColor,
              borderRadius: const BorderRadius.all(Radius.circular(7)),
              border: Border.all(color: const Color.fromRGBO(43, 43, 62, 1))),
          margin: const EdgeInsets.only(top: 10, left: 10, right: 10),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              ClipRRect(
                borderRadius: const BorderRadius.only(
                    topLeft: Radius.circular(7), topRight: Radius.circular(7)),
                child: Container(
                  height: 250,
                  color: Colors.grey.shade300,
                ),
              ),
              Container(
                  padding: const EdgeInsets.all(15),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        "${_product.brand?.name} · ${_product.model}",
                        style: Theme.of(context).textTheme.headline6,
                      ),
                      const SizedBox(
                        height: 5,
                      ),
                      if (T == Bicycle)
                        Text("Available Sizes ${_formatAvailableSizes()}",
                            style: Theme.of(context).textTheme.bodyText1),
                      if (T == Gear)
                        Text("${(_product as Gear).availableQty} Available",
                            style: Theme.of(context).textTheme.bodyText1),
                      if (T == Part)
                        Text("${(_product as Part).availableQty} Available",
                            style: Theme.of(context).textTheme.bodyText1),
                      const SizedBox(
                        height: 5,
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Text("Category · ${_product.productCategory?.name}",
                              style: Theme.of(context).textTheme.bodyText1),
                          Text("\$${_product.price}",
                              style: Theme.of(context).textTheme.headline2)
                        ],
                      ),
                    ],
                  ))
            ],
          )),
    );
  }
}
