import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:form_validator/form_validator.dart';
import 'package:pulse_admin/api/types/user/staff.dart';
import 'package:pulse_admin/components/molecules/form/named_datetime_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/named_text_form_field_group.dart';
import 'package:pulse_admin/components/molecules/form/select/role_single_select_form_group.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_row.dart';
import 'package:pulse_admin/core/style/spacing.dart';
import 'package:pulse_admin/domain/types/forms/staff_form_field_names.dart';

class StaffForm extends StatelessWidget {
  final GlobalKey<FormBuilderState> formKey;
  final Staff? initialValues;
  final bool enabled;
  final bool showPasswordFields;
  final bool showImmutableFields;

  const StaffForm(
      {super.key,
      required this.formKey,
      this.initialValues,
      this.enabled = true,
      this.showPasswordFields = false,
      this.showImmutableFields = true});

  @override
  Widget build(BuildContext context) {
    return FormBuilder(
      key: formKey,
      enabled: enabled,
      child: SpacedColumn(spacing: Spacing.lg, children: [
        SpacedRow(spacing: Spacing.md, children: [
          Expanded(
            child: NamedTextFormFieldGroup(
              name: StaffFormFieldNames.firstName,
              label: "First name",
              initialValue: initialValues?.firstName,
              validator: ValidationBuilder().minLength(2).build(),
            ),
          ),
          Expanded(
            child: NamedTextFormFieldGroup(
              name: StaffFormFieldNames.lastName,
              label: "Last name",
              initialValue: initialValues?.lastName,
              validator: ValidationBuilder().minLength(2).build(),
            ),
          ),
        ]),
        SpacedRow(spacing: Spacing.md, children: [
          Expanded(
            child: NamedTextFormFieldGroup(
              name: StaffFormFieldNames.username,
              label: "Username",
              initialValue: initialValues?.username,
              validator: ValidationBuilder().minLength(2).build(),
            ),
          ),
          Expanded(
            child: NamedTextFormFieldGroup(
              name: StaffFormFieldNames.email,
              label: "Email",
              initialValue: initialValues?.email,
              validator: ValidationBuilder().email().build(),
            ),
          ),
        ]),
        if (showPasswordFields)
          SpacedRow(spacing: Spacing.md, children: [
            Expanded(
              child: NamedTextFormFieldGroup(
                name: StaffFormFieldNames.password,
                label: "Password",
                validator: ValidationBuilder().minLength(2).build(),
                obscureText: true,
              ),
            ),
            Expanded(
              child: NamedTextFormFieldGroup(
                name: StaffFormFieldNames.passwordConfirm,
                label: "Confirm password",
                validator: ValidationBuilder().minLength(2).build(),
                obscureText: true,
              ),
            ),
          ]),
        SpacedRow(spacing: Spacing.md, children: [
          if (showImmutableFields)
            Expanded(
              child: RoleSingleSelectFormGroup(
                  enabled: enabled,
                  clearable: enabled,
                  name: StaffFormFieldNames.role,
                  label: "Role",
                  initialValue: initialValues?.role,
                  validator: FormBuilderValidators.required()),
            ),
          Expanded(
            child: NamedTextFormFieldGroup(
              name: StaffFormFieldNames.phoneNumber,
              label: "Phone number",
              initialValue: initialValues?.phoneNumber,
              validator: ValidationBuilder().minLength(2).build(),
            ),
          ),
        ]),
        if (showImmutableFields)
          SpacedRow(spacing: Spacing.md, children: [
            Expanded(
              child: NamedDatetimeFormFieldGroup(
                  name: StaffFormFieldNames.dateOfBirth,
                  label: "Date of birth",
                  initialValue: initialValues?.dateOfBirth,
                  validator: FormBuilderValidators.required()),
            ),
            Expanded(
              child: NamedDatetimeFormFieldGroup(
                  name: StaffFormFieldNames.dateOfEmployment,
                  label: "Date of employment",
                  initialValue: initialValues?.dateOfEmployment,
                  validator: FormBuilderValidators.required()),
            ),
          ]),
      ]),
    );
  }
}
