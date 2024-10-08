import 'package:flutter/material.dart';
import 'package:pulse_mobile/model/bicycle/bicycle.dart';
import 'package:pulse_mobile/utils/product_util.dart';
import 'package:pulse_mobile/utils/util.dart';

import '../model/gear/gear.dart';
import '../model/part/part.dart';
import '../model/abstract/product.dart';

class ProductListTile<T extends Product> extends StatelessWidget {
  final T _product;
  final Function(int?)? onTap;

  const ProductListTile(this._product, {super.key, this.onTap});

  String _formatAvailableSizes() =>
      (_product as Bicycle)
          .availableSizes
          ?.map((e) => e.bicycleSize?.size ?? "")
          .join(", ") ??
      "";

  @override
  Widget build(BuildContext context) {
    var isAvailable = ProductUtil.isAvailable(_product);
    print(_product.images);

    return InkWell(
      onTap: () => this.onTap!(_product.id),
      child: Container(
          decoration: BoxDecoration(
              color: Theme.of(context).colorScheme.background,
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
                  child: _product.images == null ||
                          _product.images!.isEmpty ||
                          _product.images?.first.data == null
                      ? const Center(
                          child: Icon(
                            Icons.image_not_supported_outlined,
                            color: Colors.black87,
                            size: 60,
                          ),
                        )
                      : imageFromBase64String(_product.images!.first.data!),
                ),
              ),
              Container(
                  padding: const EdgeInsets.all(15),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        "${_product.brand?.name} · ${_product.model}",
                        style: Theme.of(context).textTheme.titleLarge,
                      ),
                      const SizedBox(
                        height: 5,
                      ),
                      if (!isAvailable)
                        Text("Currently unavailable",
                            style: Theme.of(context).textTheme.bodyLarge),
                      if (isAvailable && T == Bicycle)
                        Text("Available Sizes: ${_formatAvailableSizes()}",
                            style: Theme.of(context).textTheme.bodyLarge),
                      if (isAvailable && T == Gear)
                        Text("${(_product as Gear).availableQty} Available",
                            style: Theme.of(context).textTheme.bodyLarge),
                      if (isAvailable && T == Part)
                        Text("${(_product as Part).availableQty} Available",
                            style: Theme.of(context).textTheme.bodyLarge),
                      const SizedBox(
                        height: 5,
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Text("Category · ${_product.productCategory?.name}",
                              style: Theme.of(context).textTheme.bodyLarge),
                          Text("\$${_product.price}",
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
