import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/stats/stats_provider.dart';
import 'package:pulse_admin/components/organisms/graphs/sales_graph.dart';

class StatsPage extends StatefulWidget {
  const StatsPage({super.key});

  @override
  State<StatsPage> createState() => _StatsPageState();
}

class _StatsPageState extends State<StatsPage> {
  void loadGraph(BuildContext context) =>
      context.read<StatsProvider>().getSalesByMonth();

  @override
  void initState() {
    // TODO: implement initState
    super.initState();

    loadGraph(context);
  }

  @override
  Widget build(BuildContext context) {
    return const LineChartSample2();
  }
}
