import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/dropdown.dart';
import 'package:pulse_admin/core/http/request_state.dart';
import 'package:pulse_admin/core/types/delegate.dart';
import 'package:pulse_admin/core/types/list_item.dart';

class SingleSelect<T> extends StatefulWidget {
  const SingleSelect(
      {super.key,
      this.value,
      this.width,
      required this.renderOption,
      this.text = "",
      required this.onChanged,
      required this.fetch});

  final String text;
  final T? value;
  final Delegate<T?> onChanged;
  final ListItem<T> renderOption;
  final double? width;
  final Future<List<T>> Function() fetch;

  @override
  State<SingleSelect<T>> createState() => _SingleSelectState<T>();
}

class _SingleSelectState<T> extends State<SingleSelect<T>> {
  List<T> _options = [];
  RequestState _fetchState = RequestState.init;

  @override
  void initState() {
    super.initState();

    fetchOptions();
  }

  void fetchOptions() async {
    try {
      setState(() {
        _fetchState = RequestState.loading;
      });

      var response = await widget.fetch();

      setState(() {
        _options = response;
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
    return Dropdown(
      items: _options,
      value: widget.value,
      hintText: widget.text,
      onChanged: widget.onChanged,
      renderOption: widget.renderOption,
      isLoading: _fetchState == RequestState.loading,
    );
  }
}
