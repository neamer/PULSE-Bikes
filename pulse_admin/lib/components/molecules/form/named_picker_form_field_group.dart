import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/domain/types/delegate.dart';

class NamedPickerFormFieldGroup<T> extends StatefulWidget {
  final String name;
  final TextEditingController? controller;
  final String hint;
  final bool enabled;
  final bool clearable;
  final String label;
  final T? initialValue;
  final void Function<T>(BuildContext, Delegate<T>) openPicker;
  final String? Function(T?)? validator;

  const NamedPickerFormFieldGroup({
    Key? key,
    this.hint = '',
    this.controller,
    this.enabled = true,
    this.clearable = false,
    required this.label,
    required this.name,
    this.initialValue,
    required this.openPicker,
    this.validator,
  }) : super(key: key);

  @override
  State<NamedPickerFormFieldGroup<T>> createState() =>
      _NamedPickerFormFieldGroupState<T>();
}

class _NamedPickerFormFieldGroupState<T>
    extends State<NamedPickerFormFieldGroup<T>> {
  String text = "";

  @override
  void initState() {
    super.initState();

    text = widget.initialValue?.toString() ?? "";
  }

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return SpacedColumn(
      crossAxisAlignment: CrossAxisAlignment.start,
      spacing: Spacing.md,
      children: [
        Padding(
          padding: const EdgeInsets.only(left: Spacing.xs),
          child: FieldLabel(widget.label),
        ),
        FormBuilderField<T>(
          initialValue: widget.initialValue,
          validator: widget.validator,
          name: widget.name,
          enabled: false,
          builder: (FormFieldState<T> field) {
            return InputDecorator(
              decoration: InputDecoration(
                filled: true,
                contentPadding: const EdgeInsets.symmetric(
                  horizontal: Spacing.lg,
                  vertical: Spacing.lg,
                ),
                fillColor: ColorTheme.m600,
                isDense: true,
                hintText: widget.hint,
                hintStyle: themeData.textTheme.bodyMedium!.copyWith(
                  color: ColorTheme.n500,
                ),
                border: OutlineInputBorder(
                  borderSide: BorderSide.none,
                  borderRadius: BorderRadius.circular(Radius.xs),
                ),
                suffixIcon: widget.clearable &&
                        widget.controller != null &&
                        widget.controller!.value.text.isNotEmpty
                    ? IconButton(
                        icon: const Icon(
                          Icons.clear,
                          color: ColorTheme.n500,
                        ),
                        onPressed: () {
                          widget.controller?.clear();
                        },
                      )
                    : null,
              ),
              child: InkWell(
                onTap: widget.enabled
                    ? () => widget.openPicker(context, (T item) {
                          field.setValue(item);
                          setState(() {
                            text = item?.toString() ?? "";
                          });
                        })
                    : null,
                child: Container(
                    child: Padding(
                  padding: const EdgeInsets.all(0),
                  child: Text(
                    field.value?.toString() ?? "",
                    style: themeData.textTheme.bodyMedium,
                  ),
                )),
              ),
            );
          },
        ),
      ],
    );
  }
}
