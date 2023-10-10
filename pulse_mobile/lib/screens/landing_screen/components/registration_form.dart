import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/user/requests/registration_request.dart';
import 'package:pulse_mobile/providers/auth/user_provider.dart';
import 'package:pulse_mobile/screens/product_search_screen.dart';
import 'package:pulse_mobile/utils/util.dart';
import 'package:pulse_mobile/widgets/basic_text_field.dart';

class RegistrationForm extends StatefulWidget {
  final Function switchForm;
  final Function onSuccess;

  const RegistrationForm(
      {super.key, required this.switchForm, required this.onSuccess});

  @override
  State<RegistrationForm> createState() => _RegistrationFormState();
}

class _RegistrationFormState extends State<RegistrationForm> {
  bool isSubmitting = false;

  final TextEditingController _usernameController = TextEditingController();

  final TextEditingController _passwordController = TextEditingController();

  final TextEditingController _firstNameController = TextEditingController();

  final TextEditingController _lastNameController = TextEditingController();

  final TextEditingController _emailController = TextEditingController();

  final TextEditingController _phoneNumberController = TextEditingController();

  final TextEditingController _passwordVerificationController =
      TextEditingController();

  late final UserProvider _userProvider;

  @override
  Widget build(BuildContext context) {
    _userProvider = Provider.of<UserProvider>(context, listen: false);
    var themeData = Theme.of(context);

    return Column(
      children: [
        Padding(
          padding: const EdgeInsets.all(40),
          child: Column(children: [
            BasicTextField(
              name: "Username",
              controller: _usernameController,
              enabled: !isSubmitting,
            ),
            BasicTextField(
              name: "Password",
              controller: _passwordController,
              enabled: !isSubmitting,
            ),
            BasicTextField(
              name: "First name",
              controller: _firstNameController,
              enabled: !isSubmitting,
            ),
            BasicTextField(
              name: "Last name",
              controller: _lastNameController,
              enabled: !isSubmitting,
            ),
            BasicTextField(
              name: "Email",
              controller: _emailController,
              enabled: !isSubmitting,
            ),
            BasicTextField(
              name: "Phone number",
              controller: _phoneNumberController,
              enabled: !isSubmitting,
            ),
          ]),
        ),
        const SizedBox(
          height: 2,
        ),
        OutlinedButton(
            style: ButtonStyle(
                backgroundColor: MaterialStateProperty.all<Color>(Colors.white),
                padding: MaterialStateProperty.all(
                    const EdgeInsets.symmetric(vertical: 20, horizontal: 30))),
            onPressed: () async {
              try {
                final request = RegistrationRequest.init(
                    username: _usernameController.text,
                    password: _passwordController.text,
                    passwordConfirm: _passwordController.text,
                    firstName: _firstNameController.text,
                    lastName: _lastNameController.text,
                    email: _emailController.text,
                    phoneNumber: _phoneNumberController.text);

                await _userProvider.insert(request);

                Authorization.username = _usernameController.text;
                Authorization.password = _passwordController.text;

                widget.onSuccess();
              } catch (e) {
                showDialog(
                    context: context,
                    builder: (BuildContext context) => AlertDialog(
                          title: const Text("Error"),
                          content: Text(e.toString()),
                          actions: [
                            TextButton(
                              child: const Text("Ok"),
                              onPressed: () => Navigator.pop(context),
                            )
                          ],
                        ));
              }
            },
            child: Text("REGISTER",
                style: themeData.textTheme.titleLarge?.copyWith(
                    color: themeData.colorScheme.background, fontSize: 18))),
        const SizedBox(
          height: 40,
        ),
        TextButton(
            onPressed: () => widget.switchForm(),
            child: const Text("Already have an account? Tap here to Login")),
      ],
    );
  }
}
