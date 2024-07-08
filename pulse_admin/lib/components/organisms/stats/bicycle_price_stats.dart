import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/stats/stats_provider.dart';
import 'package:pulse_admin/api/types/stats/bicycle_price_stats.dart';
import 'package:pulse_admin/components/molecules/errors/error_state.dart';
import 'package:pulse_admin/components/molecules/list/empty_state.dart';
import 'package:pulse_admin/components/organisms/charts/bicycle_price_chart.dart';
import 'package:pulse_admin/core/http/request_state.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class BicyclePriceStatsRenderer extends StatefulWidget {
  const BicyclePriceStatsRenderer({super.key});

  @override
  State<BicyclePriceStatsRenderer> createState() =>
      _BicyclePriceStatsRendererState();
}

class _BicyclePriceStatsRendererState extends State<BicyclePriceStatsRenderer> {
  List<BicyclePriceStats> _data = [];
  RequestState _fetchState = RequestState.init;

  void loadGraph(BuildContext context) async {
    setState(() {
      _fetchState = RequestState.loading;
    });
    try {
      var response = await context.read<StatsProvider>().getBicyclePriceStats();
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
  void initState() {
    super.initState();

    loadGraph(context);
  }

  @override
  Widget build(BuildContext context) {
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
                  child: BicyclePriceChart(
                    stats: _data,
                  ),
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
