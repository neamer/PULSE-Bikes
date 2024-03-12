import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/order_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/order_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/order_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/data/orders/order_header.dart';
import 'package:pulse_admin/model/filters/order_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/orders/order_provider.dart';

class OrderListPage extends StatelessWidget {
  const OrderListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
          defaultFilters: OrderFilter(
              includeCustomer: true,
              includeDetails: true,
              includePayment: true)),
      child: ListPage<OrderHeader, OrderProvider>(
        title: "Browse Orders",
        actions: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Button(text: "Add Order", onClick: () {}),
          )
        ],
        filters: const OrderListFilters(),
        listHeader: const OrderListHeader(),
        itemBuilder: (item) => OrderListItem(item),
      ),
    );
  }
}
