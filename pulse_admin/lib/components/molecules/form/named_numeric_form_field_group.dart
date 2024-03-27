import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:pulse_admin/components/atoms/typography/field_label.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class NamedNumericFormFieldGroup<T extends num> extends StatefulWidget {
  final String name;
  final TextEditingController? controller;
  final String hint;
  final bool enabled;
  final bool clearable;
  final String label;
  final num? initialValue;
  final num? max;
  final num? min;
  final num defaultValue;

  const NamedNumericFormFieldGroup(
      {Key? key,
      this.hint = '',
      this.controller,
      this.enabled = true,
      this.clearable = false,
      required this.label,
      required this.name,
      this.initialValue,
      this.max,
      this.min,
      required this.defaultValue})
      : super(key: key);

  @override
  State<NamedNumericFormFieldGroup> createState() =>
      _NamedNumericFormFieldGroupState<T>();
}

class _NamedNumericFormFieldGroupState<T extends num>
    extends State<NamedNumericFormFieldGroup> {
  final TextEditingController _controller = TextEditingController();

  @override
  void initState() {
    super.initState();
    _controller.text = (widget.initialValue ?? widget.defaultValue).toString();
  }

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);
    List<String? Function(num?)> validators = [];

    if (widget.min != null) {
      validators.add(FormBuilderValidators.min(widget.min!));
    }

    return SpacedColumn(
      crossAxisAlignment: CrossAxisAlignment.start,
      spacing: Spacing.md,
      children: [
        Padding(
          padding: const EdgeInsets.only(left: Spacing.xs),
          child: FieldLabel(widget.label),
        ),
        FormBuilderField<num>(
          initialValue: widget.initialValue,
          name: widget.name,
          enabled: widget.enabled,
          onChanged: (value) {
            _controller.text = (value ?? widget.defaultValue).toString();
          },
          validator: FormBuilderValidators.compose(validators),
          builder: (FormFieldState<num> field) {
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
              child: TextField(
                controller: _controller,
                decoration: InputDecoration(
                  isDense: true,
                  border: OutlineInputBorder(
                    borderSide: BorderSide.none,
                    borderRadius: BorderRadius.circular(Radius.xs),
                  ),
                  contentPadding: const EdgeInsets.symmetric(
                    horizontal: 0,
                    vertical: 0,
                  ),
                  fillColor: ColorTheme.m600,
                ),
                // TODO: Allow decimal number input
                inputFormatters: [
                  FilteringTextInputFormatter.allow(RegExp(r'\d*\.?\d'))
                ],
                keyboardType: TextInputType.number,
                onChanged: (value) =>
                    // ignore: invalid_use_of_protected_member
                    field.setValue(T == double
                        ? double.tryParse(value)
                        : int.tryParse(value) ?? widget.defaultValue),
                style: themeData.textTheme.bodyMedium,
              ),
            );
          },
        ),
      ],
    );
  }
}
