
typedef ListPageFilterEvent<T> = void Function(T filters);

abstract class ListPageFilters<T> {
  final ListPageFilterEvent? onFilterChange;
  final ListPageFilterEvent? onSearchClicked;

  ListPageFilterHandler({this.onSearchClicked, this.onFilterChange});
}
