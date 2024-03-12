import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/core/types/list_item.dart';

class Dropdown<T> extends StatefulWidget {
  final List<T> items;
  final T? value;
  final String hintText;
  final void Function(T?) onChanged;
  final ListItem<T> renderOption;
  final bool isLoading;

  const Dropdown({
    Key? key,
    required this.items,
    required this.value,
    required this.hintText,
    required this.onChanged,
    required this.renderOption,
    this.isLoading = false,
  }) : super(key: key);

  @override
  State<Dropdown<T>> createState() => _DropdownState<T>();
}

class _DropdownState<T> extends State<Dropdown<T>> {
  bool isHovered = false;

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    Widget? icon;
    if (widget.isLoading) {
      icon = const SizedBox(
        height: 10,
        width: 10,
        child: CircularProgressIndicator(
          color: ColorTheme.n500,
          strokeWidth: 2.5,
        ),
      );
    } else if (widget.value != null) {
      icon = IconButton(
        padding: EdgeInsets.zero,
        constraints: const BoxConstraints(),
        icon: const Icon(
          Icons.clear,
          size: 19,
          color: ColorTheme.n500,
        ),
        onPressed: () => widget.onChanged(null),
      );
    }

    return MouseRegion(
      onEnter: (event) {
        setState(() {
          isHovered = true;
        });
      },
      onExit: (event) {
        setState(() {
          isHovered = false;
        });
      },
      child: DropdownButtonFormField<T>(
        value: widget.value,
        icon: icon,
        items: widget.items.map<DropdownMenuItem<T>>((T item) {
          return DropdownMenuItem<T>(
            value: item,
            child: widget.renderOption(item),
          );
        }).toList(),
        onChanged: widget.onChanged,
        borderRadius: BorderRadius.circular(Radius.md),
        dropdownColor: ColorTheme.m600,
        decoration: InputDecoration(
          filled: true,
          contentPadding: const EdgeInsets.symmetric(
              horizontal: Spacing.lg, vertical: Spacing.lg - 1),
          fillColor:
              isHovered ? ColorTheme.m500.withAlpha(150) : ColorTheme.m600,
          isDense: true,
          hintText: widget.hintText,
          hintStyle:
              themeData.textTheme.bodyMedium!.copyWith(color: ColorTheme.n500),
          border: OutlineInputBorder(
            borderSide: BorderSide.none,
            borderRadius: BorderRadius.circular(Radius.xs),
          ),
          // suffixIcon: Icon(Icons.arrow_drop_down),
        ),
      ),
    );
  }
}
