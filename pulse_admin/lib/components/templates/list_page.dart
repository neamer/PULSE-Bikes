import 'package:flutter/material.dart';

class ListPage extends StatelessWidget {
  final String title;
  final List<Widget>? actions;

  const ListPage({super.key, this.title = "", this.actions});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(title),
        actions: actions,
      ),
      body: const Center(
        child: Text('Page One Content'),
      ),
    );
  }
}
