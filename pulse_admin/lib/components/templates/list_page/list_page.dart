import 'package:flutter/material.dart';

class ListPage extends StatelessWidget {
  final String title;
  final List<Widget>? actions;
  final ListPageEventHandler<State> filterHandler;

  const ListPage({super.key, this.title = "", this.actions});

  void fetchData(Object filters) {
    print("fetching...");
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(title),
        actions: actions,
      ),
      body: Column(children: [
          
        
      ],)
    );
  }
}
