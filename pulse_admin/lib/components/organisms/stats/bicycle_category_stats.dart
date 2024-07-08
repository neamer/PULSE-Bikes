import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/products/bicycle_category_provider.dart';
import 'package:pulse_admin/api/providers/stats/stats_provider.dart';
import 'package:pulse_admin/api/types/product_category/product_category.dart';
import 'package:pulse_admin/api/types/stats/bicycle_category_stats.dart';
import 'package:pulse_admin/components/molecules/errors/error_state.dart';
import 'package:pulse_admin/components/molecules/list/empty_state.dart';
import 'package:pulse_admin/components/organisms/charts/bicycle_category_chart.dart';
import 'package:pulse_admin/core/http/request_state.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class BicycleCategoryStatsRenderer extends StatefulWidget {
  const BicycleCategoryStatsRenderer({super.key});

  @override
  State<BicycleCategoryStatsRenderer> createState() =>
      _BicycleCategoryStatsRendererState();
}

class _BicycleCategoryStatsRendererState
    extends State<BicycleCategoryStatsRenderer> {
  List<BicycleCategoryStats> _data = [];
  RequestState _statsFetchState = RequestState.init;

  List<ProductCategory> _categories = [];
  RequestState _categoriesFetchState = RequestState.init;

  void loadGraph(BuildContext context) async {
    setState(() {
      _statsFetchState = RequestState.loading;
    });
    try {
      var response =
          await context.read<StatsProvider>().getBicycleCategoryStats();
      setState(() {
        _data = response;
        _statsFetchState = RequestState.success;
      });
    } catch (e) {
      setState(() {
        _statsFetchState = RequestState.error;
      });
    }
  }

  void loadCategories(BuildContext context) async {
    setState(() {
      _categoriesFetchState = RequestState.loading;
    });
    try {
      var response = await context.read<BicycleCategoryProvider>().get();
      setState(() {
        _categories = response;
        _categoriesFetchState = RequestState.success;
      });
    } catch (e) {
      setState(() {
        _categoriesFetchState = RequestState.error;
      });
    }
  }

  @override
  void initState() {
    super.initState();

    loadGraph(context);
    loadCategories(context);
  }

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        if (_statsFetchState == RequestState.loading ||
            _categoriesFetchState == RequestState.loading)
          const Center(
              child: Padding(
            padding: EdgeInsets.all(20),
            child: CircularProgressIndicator(),
          )),
        if (_statsFetchState == RequestState.success &&
            _categoriesFetchState == RequestState.success)
          _data.isEmpty
              ? Padding(
                  padding: const EdgeInsets.all(Spacing.lg),
                  child: EmptyState(onRetry: () => loadGraph(context)),
                )
              : Padding(
                  padding: const EdgeInsets.symmetric(horizontal: Spacing.lg),
                  child: BicycleCategoryChart(
                    stats: _data,
                    categories: _categories,
                  ),
                ),
        if (_categoriesFetchState == RequestState.error &&
            _categoriesFetchState == RequestState.error)
          Padding(
            padding: const EdgeInsets.only(top: Spacing.xxl),
            child: ErrorState(onRetry: () => loadGraph(context)),
          )
      ],
    );
  }
}
