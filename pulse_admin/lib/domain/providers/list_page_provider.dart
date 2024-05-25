import 'package:flutter/material.dart';
import 'package:pulse_admin/core/events/event_handler.dart';
import 'package:pulse_admin/domain/types/filters/abstract_filter.dart';

class ListPageProvider extends ChangeNotifier {
  final EventHandler<Filter> searchEvent = EventHandler();
  final EventHandler fetchEvent = EventHandler();

  final Filter? defaultFilters;

  ListPageProvider({this.defaultFilters});
}
