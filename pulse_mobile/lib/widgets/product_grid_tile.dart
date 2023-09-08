import 'package:flutter/material.dart';

import '../model/product/product.dart';

class ProductGridTile extends StatelessWidget {
  final Product _product;
  final Function(int?)? onTap;

  ProductGridTile(this._product, {this.onTap});

  @override
  Widget build(BuildContext context) {
    return InkWell(
      onTap: () => this.onTap!(_product.productId),
      child: Container(
          decoration: BoxDecoration(
              color: Theme.of(context).backgroundColor,
              borderRadius: BorderRadius.all(Radius.circular(7)),
              border: Border.all(color: Color.fromRGBO(43, 43, 62, 1))),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              ClipRRect(
                borderRadius: BorderRadius.only(
                    topLeft: Radius.circular(7), topRight: Radius.circular(7)),
                child: Container(
                  height: 120,
                  color: Colors.grey.shade300,
                ),
              ),
              Container(
                  padding: EdgeInsets.all(15),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        "${_product.brand?.name}",
                        style: Theme.of(context)
                            .textTheme
                            .headline6
                            ?.copyWith(fontSize: 18),
                      ),
                      SizedBox(
                        height: 5,
                      ),
                      SingleChildScrollView(
                        physics: BouncingScrollPhysics(),
                        scrollDirection: Axis.horizontal,
                        child: Container(
                          height: 20,
                          child: Text(
                            "${_product.model}",
                            maxLines: 1,
                            style: Theme.of(context)
                                .textTheme
                                .headline6
                                ?.copyWith(fontSize: 18),
                          ),
                        ),
                      ),
                      // SizedBox(
                      //   height: 5,
                      // ),
                      // Text("Available Sizes",
                      //     style: Theme.of(context).textTheme.bodyText1),
                      SizedBox(
                        height: 5,
                      ),
                      Text("${_product.productCategory?.name}",
                          style: Theme.of(context)
                              .textTheme
                              .bodyText1
                              ?.copyWith(fontSize: 16)),
                      SizedBox(
                        height: 5,
                      ),
                      Text("\$${_product.price}",
                          style: Theme.of(context)
                              .textTheme
                              .headline2
                              ?.copyWith(fontSize: 16))
                    ],
                  ))
            ],
          )),
    );
  }
}
