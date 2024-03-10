import 'package:flutter/material.dart';
import 'package:pulse_admin/components/atoms/dropdown.dart';
import 'package:pulse_admin/core/http/fetch_state.dart';
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
  FetchState _fetchState = FetchState.init;

  @override
  void initState() {
    super.initState();

    fetchOptions();
  }

  void fetchOptions() async {
    try {
      setState(() {
        _fetchState = FetchState.loading;
      });

      var response = await widget.fetch();

      setState(() {
        _options = response;
        _fetchState = FetchState.success;
      });
    } catch (e) {
      setState(() {
        _fetchState = FetchState.error;
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
      renderOption: ((item) => Text(
            item.toString(),
            style: Theme.of(context).textTheme.bodyMedium,
          )),
      isLoading: _fetchState == FetchState.loading,
    );
  }
}
