import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/stats/stats_provider.dart';
import 'package:pulse_admin/api/types/stats/stats.dart';
import 'package:pulse_admin/components/molecules/errors/error_state.dart';
import 'package:pulse_admin/components/molecules/list/empty_state.dart';
import 'package:pulse_admin/components/organisms/charts/sales_chart.dart';
import 'package:pulse_admin/core/http/request_state.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class SalesLineChart extends StatefulWidget {
  final int selectedYear;
  const SalesLineChart({super.key, required this.selectedYear});

  @override
  State<SalesLineChart> createState() => _SalesLineChartState();
}

class _SalesLineChartState extends State<SalesLineChart> {
  List<Stats> _data = [];
  RequestState _fetchState = RequestState.init;
  int fetchedYear = 0;

  void loadGraph(BuildContext context) async {
    setState(() {
      _fetchState = RequestState.loading;
    });
    try {
      var response = await context
          .read<StatsProvider>()
          .getSalesByMonth(widget.selectedYear);
      setState(() {
        _data = response;
        _fetchState = RequestState.success;
      });
    } catch (e) {
      setState(() {
        _fetchState = RequestState.error;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    if (widget.selectedYear != fetchedYear) {
      loadGraph(context);
      fetchedYear = widget.selectedYear;
    }

    return Column(
      children: [
        if (_fetchState == RequestState.loading)
          const Center(
              child: Padding(
            padding: EdgeInsets.all(20),
            child: CircularProgressIndicator(),
          )),
        if (_fetchState == RequestState.success)
          _data.isEmpty
              ? Padding(
                  padding: const EdgeInsets.all(Spacing.lg),
                  child: EmptyState(onRetry: () => loadGraph(context)),
                )
              : Padding(
                  padding: const EdgeInsets.symmetric(horizontal: Spacing.lg),
                  child: SalesChart(_data),
                ),
        if (_fetchState == RequestState.error)
          Padding(
            padding: const EdgeInsets.only(top: Spacing.xxl),
            child: ErrorState(onRetry: () => loadGraph(context)),
          )
      ],
    );
  }
}
