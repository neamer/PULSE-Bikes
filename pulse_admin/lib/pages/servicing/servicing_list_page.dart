import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/servicing/servicing_provider.dart';
import 'package:pulse_admin/api/types/servicing/servicing.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/organisms/filters/servicing_list_filters.dart';
import 'package:pulse_admin/components/organisms/lists/headers/servicing_list_header.dart';
import 'package:pulse_admin/components/organisms/lists/items/servicing_list_item.dart';
import 'package:pulse_admin/components/templates/list_page.dart';
import 'package:pulse_admin/domain/types/filters/servicing_filter.dart';
import 'package:pulse_admin/pages/servicing/servicing_details_page.dart';
import 'package:pulse_admin/pages/servicing/servicing_register_page.dart';
import 'package:pulse_admin/domain/providers/list_page_provider.dart';
import 'package:pulse_admin/utils/navigation_utils.dart';

class ServicingListPage extends StatelessWidget {
  const ServicingListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (context) => ListPageProvider(
          defaultFilters: ServicingFilter(
              includeCustomer: true, includeParts: true, includePayment: true)),
      child: const _ServicingListPage(),
    );
  }
}

class _ServicingListPage extends StatelessWidget {
  const _ServicingListPage();

  void onActionSuccess(BuildContext context) =>
      context.read<ListPageProvider>().fetchEvent.publish(null);

  @override
  Widget build(BuildContext context) {
    return ListPage<Servicing, ServicingProvider>(
      title: "Browse Servicings",
      actions: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Button(
              text: "Register servicing",
              onClick: () => openOverlay(
                  context,
                  ServicingRegisterPage(
                    onSuccess: () => onActionSuccess(context),
                  ))),
        )
      ],
      filters: const ServicingListFilters(),
      listHeader: const ServicingListHeader(),
      itemBuilder: (item) => ServicingListItem(
        item,
        onClick: () => openOverlay(
            context,
            ServicingDetailsPage(
              item,
              onSuccess: () => onActionSuccess(context),
            )),
      ),
    );
  }
}
