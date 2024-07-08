import 'package:fl_chart/fl_chart.dart';
import 'package:flutter/material.dart';
import 'package:pulse_admin/api/types/stats/stats.dart';
import 'package:pulse_admin/core/style/colors.dart';

int getUpperBoundary(double max) {
  int powerOfTen = 10;

  while (powerOfTen <= max) {
    powerOfTen *= 10;
  }

  return powerOfTen;
}

class SalesChart extends StatelessWidget {
  final List<Stats> data;

  SalesChart(this.data, {super.key});

  final List<Color> gradientColors = [
    ColorTheme.b300,
    ColorTheme.g400,
  ];

  @override
  Widget build(BuildContext context) {
    final double maxValue = data
        .reduce((currMax, element) =>
            currMax.value! > element.value! ? currMax : element)
        .value!;

    final upperBoundary = getUpperBoundary(maxValue);
    final multiplier = upperBoundary / 10;

    return Stack(
      children: <Widget>[
        AspectRatio(
          aspectRatio: 1.70,
          child: Padding(
            padding: const EdgeInsets.only(
              right: 18,
              left: 12,
              top: 24,
              bottom: 12,
            ),
            child: LineChart(
              LineChartData(
                gridData: FlGridData(
                  show: true,
                  drawVerticalLine: true,
                  horizontalInterval: 1,
                  verticalInterval: 1,
                  getDrawingHorizontalLine: (value) {
                    return const FlLine(
                      color: ColorTheme.m500,
                      strokeWidth: 1,
                    );
                  },
                  getDrawingVerticalLine: (value) {
                    return const FlLine(
                      color: ColorTheme.m500,
                      strokeWidth: 1,
                    );
                  },
                ),
                titlesData: FlTitlesData(
                  show: true,
                  rightTitles: const AxisTitles(
                    sideTitles: SideTitles(showTitles: false),
                  ),
                  topTitles: const AxisTitles(
                    sideTitles: SideTitles(showTitles: false),
                  ),
                  bottomTitles: AxisTitles(
                    sideTitles: SideTitles(
                      showTitles: true,
                      reservedSize: 30,
                      interval: 1,
                      getTitlesWidget: bottomTitleWidgets,
                    ),
                  ),
                  leftTitles: AxisTitles(
                    sideTitles: SideTitles(
                      showTitles: true,
                      interval: 2,
                      getTitlesWidget: (double value, TitleMeta meta) {
                        if (multiplier >= 1000) {
                          return Text("${(value * multiplier / 1000).toInt()}k",
                              style: const TextStyle(
                                fontWeight: FontWeight.bold,
                                fontSize: 15,
                              ),
                              textAlign: TextAlign.left);
                        } else {
                          return Text("${(value * multiplier).toInt()}",
                              style: const TextStyle(
                                fontWeight: FontWeight.bold,
                                fontSize: 15,
                              ),
                              textAlign: TextAlign.left);
                        }
                      },
                      reservedSize: 42,
                    ),
                  ),
                ),
                borderData: FlBorderData(
                  show: true,
                  border: Border.all(color: const Color(0xff37434d)),
                ),
                minX: 1,
                maxX: 12,
                minY: 0,
                maxY: 10,
                lineBarsData: [
                  LineChartBarData(
                    spots: data
                        .map((item) => FlSpot(
                            item.month!.toDouble(), item.value! / multiplier))
                        .toList(),
                    isCurved: true,
                    gradient: LinearGradient(
                      colors: gradientColors,
                    ),
                    barWidth: 5,
                    isStrokeCapRound: true,
                    dotData: const FlDotData(
                      show: false,
                    ),
                    belowBarData: BarAreaData(
                      show: true,
                      gradient: LinearGradient(
                        colors: gradientColors
                            .map((color) => color.withOpacity(0.3))
                            .toList(),
                      ),
                    ),
                  ),
                ],
              ),
            ),
          ),
        ),
      ],
    );
  }

  Widget bottomTitleWidgets(double value, TitleMeta meta) {
    const style = TextStyle(
      fontWeight: FontWeight.bold,
      fontSize: 16,
    );
    Widget text;
    switch (value.toInt()) {
      case 1:
        text = const Text('JAN', style: style);
        break;
      case 3:
        text = const Text('MAR', style: style);
        break;
      case 5:
        text = const Text('MAY', style: style);
        break;
      case 7:
        text = const Text('JUL', style: style);
        break;
      case 9:
        text = const Text('SEP', style: style);
        break;
      case 11:
        text = const Text('NOV', style: style);
        break;
      default:
        text = const Text('', style: style);
        break;
    }

    return SideTitleWidget(
      axisSide: meta.axisSide,
      child: text,
    );
  }
}
