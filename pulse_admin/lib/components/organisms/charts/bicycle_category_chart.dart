import 'package:fl_chart/fl_chart.dart';
import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/product_category/product_category.dart';
import 'package:pulse_admin/api/types/stats/bicycle_category_stats.dart';
import 'package:pulse_admin/core/style/colors.dart';

class BicycleCategoryChart extends StatefulWidget {
  final List<BicycleCategoryStats> stats;
  final List<ProductCategory> categories;

  const BicycleCategoryChart(
      {super.key, required this.stats, required this.categories});

  @override
  State<StatefulWidget> createState() => BicycleCategoryChartState();
}

class BicycleCategoryChartState extends State<BicycleCategoryChart> {
  @override
  Widget build(BuildContext context) {
    return AspectRatio(
      aspectRatio: 2,
      child: BarChart(
        BarChartData(
          barTouchData: barTouchData,
          titlesData: titlesData,
          borderData: borderData,
          barGroups: barGroups,
          gridData: const FlGridData(show: false),
          alignment: BarChartAlignment.spaceAround,
          maxY: 20,
        ),
      ),
    );
  }

  BarTouchData get barTouchData => BarTouchData(
        enabled: false,
        touchTooltipData: BarTouchTooltipData(
          getTooltipColor: (group) => Colors.transparent,
          tooltipPadding: EdgeInsets.zero,
          tooltipMargin: 8,
          getTooltipItem: (
            BarChartGroupData group,
            int groupIndex,
            BarChartRodData rod,
            int rodIndex,
          ) {
            return BarTooltipItem(
              rod.toY.round().toString(),
              const TextStyle(
                color: ColorTheme.b300,
                fontWeight: FontWeight.bold,
              ),
            );
          },
        ),
      );

  Widget getTitles(double value, TitleMeta meta) {
    const style = TextStyle(
      color: ColorTheme.n500,
      fontWeight: FontWeight.bold,
      fontSize: 14,
    );
    return SideTitleWidget(
      axisSide: meta.axisSide,
      space: 4,
      child: Text(
          widget.categories
                  .where((category) => category.id == value)
                  .firstOrNull!
                  .name ??
              "",
          style: style),
    );
  }

  FlTitlesData get titlesData => FlTitlesData(
        show: true,
        bottomTitles: AxisTitles(
          sideTitles: SideTitles(
            showTitles: true,
            reservedSize: 30,
            getTitlesWidget: getTitles,
          ),
        ),
        leftTitles: const AxisTitles(
          sideTitles: SideTitles(showTitles: false),
        ),
        topTitles: const AxisTitles(
          sideTitles: SideTitles(showTitles: false),
        ),
        rightTitles: const AxisTitles(
          sideTitles: SideTitles(showTitles: false),
        ),
      );

  FlBorderData get borderData => FlBorderData(
        show: false,
      );

  LinearGradient get _barsGradient => const LinearGradient(
        colors: [
          ColorTheme.b300,
          ColorTheme.g400,
        ],
        begin: Alignment.bottomCenter,
        end: Alignment.topCenter,
      );

  List<BarChartGroupData> get barGroups => widget.stats
      .map((item) => BarChartGroupData(
            x: item.categoryId!,
            barRods: [
              BarChartRodData(
                toY: item.value!,
                gradient: _barsGradient,
              )
            ],
            showingTooltipIndicators: [0],
          ))
      .toList();
}
