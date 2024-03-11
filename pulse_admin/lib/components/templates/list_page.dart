import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/molecules/errors/error_state.dart';
import 'package:pulse_admin/core/http/fetch_state.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/core/types/list_item.dart';
import 'package:pulse_admin/model/filters/abstract_filter.dart';
import 'package:pulse_admin/providers/core/list_page_provider.dart';
import 'package:pulse_admin/providers/http/base/base_provider.dart';

class ListPage<T, TProvider extends BaseProvider<T>> extends StatefulWidget {
  final String title;
  final List<Widget>? actions;
  final Widget? filters;
  final Widget? listHeader;
  final ListItem itemBuilder;

  const ListPage(
      {super.key,
      this.title = "",
      this.actions,
      this.filters,
      required this.itemBuilder,
      this.listHeader});

  @override
  State<ListPage> createState() => _ListPageState<T, TProvider>();
}

class _ListPageState<T, TProvider extends BaseProvider<T>>
    extends State<ListPage> {
  FetchState _fetchState = FetchState.init;
  List<T> _data = [];

  TProvider? _provider;

  @override
  void initState() {
    super.initState();

    _provider = context.read<TProvider>();
    context.read<ListPageProvider>().searchEvent.subscribe(fetchData);

    fetchData(context.read<ListPageProvider>().defaultFilters);
  }

  void fetchData(AbstractFilter? filters) async {
    try {
      setState(() {
        _fetchState = FetchState.loading;
      });

      var response = await _provider!.get(filters?.toQuery());

      setState(() {
        _data = response;
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
    return Scaffold(
        appBar: AppBar(
          backgroundColor: ColorTheme.m800,
          title: Text(widget.title),
          actions: widget.actions,
        ),
        body: ListView(
          children: [
            if (widget.filters != null)
              Padding(
                  padding: const EdgeInsets.all(Spacing.md),
                  child: widget.filters!),
            if (widget.listHeader != null)
              Padding(
                  padding: const EdgeInsets.only(
                      left: Spacing.lg + Spacing.lg,
                      right: Spacing.lg + Spacing.lg,
                      top: Spacing.sm,
                      bottom: Spacing.md),
                  child: widget.listHeader!),
            if (_fetchState == FetchState.loading)
              const Center(
                  child: Padding(
                padding: EdgeInsets.all(20),
                child: CircularProgressIndicator(),
              )),
            if (_fetchState == FetchState.success)
              Padding(
                padding: const EdgeInsets.symmetric(horizontal: Spacing.lg),
                child: ListView.builder(
                    shrinkWrap: true,
                    physics: const ScrollPhysics(),
                    itemCount: _data.length,
                    itemBuilder: (ctx, index) => widget.itemBuilder(
                          _data[index],
                        )),
              ),
            if (_fetchState == FetchState.error)
              Padding(
                padding: const EdgeInsets.only(top: Spacing.xxl),
                child: ErrorState(
                    onRetry: () => fetchData(
                        context.read<ListPageProvider>().defaultFilters)),
              )
          ],
        ));
  }
}
