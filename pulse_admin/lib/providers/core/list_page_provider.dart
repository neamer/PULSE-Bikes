import 'package:flutter/material.dart';
import 'package:pulse_admin/core/events/event_handler.dart';
import 'package:pulse_admin/model/filters/abstract_filter.dart';

class ListPageProvider extends ChangeNotifier {
  final EventHandler<AbstractFilter> searchEvent = EventHandler();
  final AbstractFilter? defaultFilters;

  ListPageProvider({this.defaultFilters});
}
