import 'package:flutter/material.dart';
import 'package:pulse_mobile/model/servicing/servicing.dart';
import 'package:pulse_mobile/utils/util.dart';

class ServicingListItem extends StatelessWidget {
  final Servicing item;
  final Function onClick;

  const ServicingListItem(this.item, this.onClick, {super.key});

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.only(bottom: 15),
      child: InkWell(
        onTap: () => onClick(),
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
                  Container(
                      padding: const EdgeInsets.all(14),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(
                            "${item.servicingNumber}",
                            style: Theme.of(context)
                                .textTheme
                                .titleLarge
                                ?.copyWith(fontSize: 18),
                          ),
                          // const SizedBox(
                          //   height: 5,
                          // ),
                          // if (item. != null)
                          //   Text(
                          //       DateFormat.yMMMEd().format(item.timeProcessed!),
                          //       style: Theme.of(context)
                          //           .textTheme
                          //           .bodyLarge
                          //           ?.copyWith(fontSize: 15)),
                          const SizedBox(
                            height: 7,
                          ),
                          Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            children: [
                              Text(
                                  "Status · ${GetServicingStateName(ServicingState.values[item.status!])}",
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
          // Positioned(
          //     bottom: 14,
          //     right: 14,
          //     child: Text("\$${item.getTotal().toString()}",
          //         style: Theme.of(context)
          //             .textTheme
          //             .displayMedium
          //             ?.copyWith(fontSize: 14)))
        ]),
      ),
    );
  }
}