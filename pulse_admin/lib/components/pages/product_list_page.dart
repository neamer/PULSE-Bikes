import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/templates/list_page.dart';

class ProductListPage extends StatelessWidget {
  const ProductListPage({super.key});

  @override
  Widget build(BuildContext context) {
    return ListPage(
      title: "Browse products",
      actions: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Button(text: "Add Bicycle", onClick: () {}),
        )
      ],
    );
  }
}
