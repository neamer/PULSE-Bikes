import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/order_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/order_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/order_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/data/orders/order_header.dart';
import 'package:pulse_admin/model/filters/order_filter.dart';
import 'package:pulse_admin/pages/order/order_add_page.dart';
import 'package:pulse_admin/pages/order/order_details_page.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/orders/order_provider.dart';
import 'package:pulse_admin/utils/confirmation_util.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class OrderListPage extends StatelessWidget {
  const OrderListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
          defaultFilters: OrderFilter(
              includePayment: true,
              includeDetails: true,
              includeCustomer: true,
              includeShippingInfo: true)),
      child: const _OrderListPage(),
    );
  }
}

class _OrderListPage extends StatelessWidget {
  const _OrderListPage();

  void onActionSuccess(BuildContext context) =>
      context.read<ListPageProvider>().fetchEvent.publish(null);

  Future deleteItem(BuildContext context, OrderHeader item) async {
    await context.read<OrderProvider>().delete(item.id!);
    onActionSuccess(context);
  }

  @override
  Widget build(BuildContext context) {
    return ListPage<OrderHeader, OrderProvider>(
      title: "Orders",
      actions: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Button(
              text: "Add Order",
              onClick: () => openOverlay(
                  context,
                  OrderAddPage(
                    onSuccess: () => context
                        .read<ListPageProvider>()
                        .fetchEvent
                        .publish(null),
                  ))),
        )
      ],
      filters: const OrderListFilters(),
      listHeader: const OrderListHeader(),
      itemBuilder: (item) => OrderListItem(
        item,
        actions: [
          IconButton(
            icon: const Icon(
              Icons.delete_outline,
              color: ColorTheme.r400,
            ),
            onPressed: () {
              showDeleteConfirmationDialog(
                  context,
                  genericRequestHandler(
                      context, () => deleteItem(context, item),
                      successMessage:
                          "Successfully deleted brand ${item.orderNumber}"));
            },
          ),
        ],
        onClick: () => openOverlay(
            context,
            OrderDetailsPage(
              item,
              refetchList: () =>
                  context.read<ListPageProvider>().fetchEvent.publish(null),
            )),
      ),
    );
  }
}
