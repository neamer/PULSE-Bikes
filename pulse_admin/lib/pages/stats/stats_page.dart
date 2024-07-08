import 'package:flutter/material.dart';
import 'package:pulse_admin/components/molecules/select/single/statistics_option_single_select.dart';
import 'package:pulse_admin/components/molecules/select/single/year_single_select.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/components/organisms/charts/revenue_line_chart.dart';
import 'package:pulse_admin/components/organisms/charts/sales_line_chart.dart';
import 'package:pulse_admin/components/organisms/stats/bicycle_category_stats.dart';
import 'package:pulse_admin/components/organisms/stats/bicycle_price_stats.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/sizes.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/domain/types/statistics_option.dart';

class StatsPage extends StatefulWidget {
  const StatsPage({super.key});

  @override
  State<StatsPage> createState() => _StatsPageState();
}

class _StatsPageState extends State<StatsPage> {
  StatisticsOption _selectedOption = StatisticsOption.salesByMonth;
  int _selectedYear = DateTime.now().year;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          scrolledUnderElevation: 0,
          backgroundColor: ColorTheme.m750,
          title: const Text("Statistics"),
        ),
        body: Center(
          child: Container(
            constraints: BoxConstraints(
                minWidth: AppSizes.statsMinWidth,
                maxWidth: AppSizes.statsMaxWidth),
            child: Column(
              children: [
                Padding(
                  padding: const EdgeInsets.only(
                      top: Spacing.xl,
                      right: Spacing.xxl,
                      left: 2 * Spacing.xxl,
                      bottom: Spacing.lg),
                  child: SpacedRow(
                    spacing: Spacing.md,
                    children: [
                      Expanded(
                        flex: 80,
                        child: StatisticsOptionSingleSelect(
                          onChanged: (option) => setState(() {
                            _selectedOption = option!;
                          }),
                          width: double.infinity,
                          value: _selectedOption,
                        ),
                      ),
                      if (_selectedOption == StatisticsOption.revenueByMonth ||
                          _selectedOption == StatisticsOption.salesByMonth)
                        Expanded(
                          flex: 20,
                          child: YearSingleSelect(
                              width: double.infinity,
                              onChanged: (selected) => setState(() {
                                    _selectedYear = selected!;
                                  }),
                              value: _selectedYear,
                              min: 2023,
                              max: DateTime.now().year),
                        ),
                    ],
                  ),
                ),
                if (_selectedOption == StatisticsOption.revenueByMonth)
                  RevenueLineChart(
                    selectedYear: _selectedYear,
                  ),
                if (_selectedOption == StatisticsOption.salesByMonth)
                  SalesLineChart(
                    selectedYear: _selectedYear,
                  ),
                if (_selectedOption == StatisticsOption.bikesSoldByType)
                  const BicycleCategoryStatsRenderer(),
                if (_selectedOption == StatisticsOption.bikesSoldByPrice)
                  const BicyclePriceStatsRenderer()
              ],
            ),
          ),
        ));
  }
}
