import 'package:pulse_admin/domain/types/delegate.dart';

class EventHandler<T> {
  final List<Delegate<T>> _subscribers = [];

  void subscribe(Delegate<T> function) {
    _subscribers.add(function);
  }

  void publish(T args) {
    for (var element in _subscribers) {
      element(args);
    }
  }
}
