import 'package:flutter/material.dart';
import 'package:non_linear_slider/models/interval.dart';

class NonLinearRangeSlider extends StatelessWidget {
  final List<NLSInterval> sliderIntervals = [];

  final List<NLSInterval> consumerIntervals;
  final Function(RangeValues) onChanged;
  final RangeValues values;
  final int? divisions;
  final ValueChanged<RangeValues>? onChangeStart;
  final ValueChanged<RangeValues>? onChangeEnd;
  final RangeValues? initialValue;
  final Color? activeColor;
  final Color? inactiveColor;
  final SemanticFormatterCallback? semanticFormatterCallback;

  NonLinearRangeSlider({
    Key? key,
    required List<NLSInterval> intervals,
    required this.values,
    required this.onChanged,
    this.onChangeStart,
    this.onChangeEnd,
    this.initialValue,
    this.activeColor,
    this.inactiveColor,
    this.semanticFormatterCallback,
    this.divisions,
  })  : consumerIntervals = intervals,
        super(key: key) {
    _checkIntervals();
    _setIntervals();
  }

  @override
  Widget build(BuildContext context) {
    return RangeSlider(
      values: RangeValues(
        _consumerToSlider(values.start),
        _consumerToSlider(values.end),
      ),
      onChanged: (RangeValues sliderValue) {
        onChanged(RangeValues(
          _sliderToConsumer(sliderValue.start),
          _sliderToConsumer(sliderValue.end),
        ));
      },
      min: 0,
      max: 100,
      divisions: divisions,
      onChangeEnd: onChangeEnd,
      onChangeStart: onChangeStart,
      activeColor: activeColor,
      inactiveColor: inactiveColor,
      semanticFormatterCallback: semanticFormatterCallback,
      labels: RangeLabels(
        values.start.round().toString(),
        values.end.round().toString(),
      ),
    );
  }

  void _setIntervals() {
    int i = 0;
    for (final NLSInterval interval in consumerIntervals) {
      double min = i == 0 ? 0 : sliderIntervals.last.max;
      double max = min + interval.weight * 100;
      sliderIntervals.add(NLSInterval(min, max, interval.weight));
      i++;
    }
  }

  void _checkIntervals() {
    double totalValue = 0;
    for (int i = 0; i < consumerIntervals.length; i++) {
      final NLSInterval interval = consumerIntervals[i];
      totalValue += interval.weight;
      assert(interval.min <= interval.max,
          'El mínimo de un intervalo tiene que ser menor que el máximo');
      if (i == 0) continue;
      if (consumerIntervals.length > 1)
        assert(interval.min == consumerIntervals[i - 1].max,
            'El minimo de un intervalo tiene que ser igual la maximo del anterior');
    }
    assert(totalValue.round() == 1,
        'La suma de los porcentajes que ocupa cada intervalo ha de ser igual a 1');
  }

  double _sliderToConsumer(double sliderValue) {
    double val = consumerIntervals.first.min;
    int i = 0;
    for (final NLSInterval interval in sliderIntervals) {
      NLSInterval consumerInterval = consumerIntervals[i];
      if (interval.max < sliderValue)
        val = consumerInterval.max;
      else {
        val += (sliderValue - interval.min) *
            ((consumerInterval.max - consumerInterval.min) /
                (interval.max - interval.min));
        break;
      }
      i++;
    }
    return val;
  }

  double _consumerToSlider(double consumerValue) {
    late NLSInterval ci, si;
    int index = 0;

    for (final NLSInterval interval in consumerIntervals) {
      if (interval.max < consumerValue) {
        index++;
        continue;
      }
      ci = interval;
      si = sliderIntervals[index];
      break;
    }
    return si.min +
        (consumerValue - ci.min) * ((si.max - si.min) / (ci.max - ci.min));
  }
}
