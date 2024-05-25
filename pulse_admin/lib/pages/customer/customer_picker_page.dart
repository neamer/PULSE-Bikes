import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/customer/customer_provider.dart';
import 'package:pulse_admin/api/types/user/customer.dart';
import 'package:pulse_admin/components/organisms/filters/basic_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/customer_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/customer_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/domain/providers/list_page_provider.dart';
import 'package:pulse_admin/domain/types/delegate.dart';
import 'package:pulse_admin/domain/types/filters/basic_filter.dart';

class CustomerPickerPage extends StatefulWidget {
  final Delegate<Customer> onPick;

  const CustomerPickerPage({super.key, required this.onPick});

  @override
  State<CustomerPickerPage> createState() => _CustomerPickerPageState();
}

class _CustomerPickerPageState extends State<CustomerPickerPage> {
  void itemPicked(Customer item) {
    widget.onPick(item);
    Navigator.pop(context);
  }

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(defaultFilters: BasicFilter()),
      child: ListPage<Customer, CustomerProvider>(
        title: "Select Customer",
        filters: const BasicListFilters(),
        listHeader: const CustomerListHeader(),
        itemBuilder: (item) => CustomerListItem(
          item,
          onClick: () => itemPicked(item),
        ),
      ),
    );
  }
}
