import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/atoms/fields/text_field.dart';
import 'package:pulse_admin/components/molecules/select/single/order_status_single_select.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/model/filters/order_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';

class OrderListFilters extends StatefulWidget {
  const OrderListFilters({super.key});

  @override
  State<StatefulWidget> createState() {
    return _OrderListFilterState();
  }
}

class _OrderListFilterState extends State<OrderListFilters> {
  final TextEditingController searchController = TextEditingController();
  final OrderFilter _data = OrderFilter(
      includeCustomer: true,
      includeDetails: true,
      includePayment: true,
      includeShippingInfo: true);

  @override
  void initState() {
    super.initState();
    searchController.addListener(() => setState(() {
          _data.anyField = searchController.text;
        }));
    context.read<ListPageProvider>().fetchEvent.subscribe((arg) {
      fetchWithFilters();
    });
  }

  void fetchWithFilters() =>
      context.read<ListPageProvider>().searchEvent.publish(_data);

  @override
  Widget build(BuildContext context) {
    return SpacedRow(
      spacing: Spacing.md,
      children: [
        Expanded(
          child: TextInput(
            controller: searchController,
            hint: 'Enter your search criteria',
            clearable: true,
          ),
        ),
        OrderStatusSingleSelect(
            width: 170,
            value: _data.status,
            onChanged: (value) => setState(() {
                  _data.status = value;
                })),
        Button(text: "Search", onClick: fetchWithFilters)
      ],
    );
  }
}
