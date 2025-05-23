import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/providers/auth/user_provider.dart';
import 'package:pulse_mobile/utils/messages.dart';
import 'package:pulse_mobile/widgets/basic_text_field.dart';

import '../../../utils/util.dart';

class LoginForm extends StatefulWidget {
  final Function switchForm;
  final Function onSuccess;

  const LoginForm(
      {super.key, required this.switchForm, required this.onSuccess});

  @override
  State<LoginForm> createState() => _LoginFormState();
}

class _LoginFormState extends State<LoginForm> {
  bool isSubmitting = false;

  final TextEditingController _usernameController = TextEditingController();

  final TextEditingController _passwordController = TextEditingController();

  UserProvider? _userProvider;

  @override
  Widget build(BuildContext context) {
    _userProvider = Provider.of<UserProvider>(context, listen: false);
    var themeData = Theme.of(context);

    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 40.0),
      child: Column(
        children: [
          Column(children: [
            BasicTextField(
              name: "Username",
              controller: _usernameController,
              enabled: !isSubmitting,
            ),
            BasicTextField(
              name: "Password",
              controller: _passwordController,
              enabled: !isSubmitting,
              obscureText: true,
            ),
          ]),
          const SizedBox(
            height: 40,
          ),
          OutlinedButton(
              style: ButtonStyle(
                  minimumSize:
                      MaterialStateProperty.all(const Size.fromHeight(50)),
                  backgroundColor:
                      MaterialStateProperty.all<Color>(Colors.white),
                  padding: MaterialStateProperty.all(const EdgeInsets.symmetric(
                      vertical: 20, horizontal: 30))),
              onPressed: () async {
                setState(() {
                  isSubmitting = true;
                });
                try {
                  Authorization.username = _usernameController.text;
                  Authorization.password = _passwordController.text;

                  await _userProvider?.login();

                  widget.onSuccess();
                } catch (e) {
                  Messages.errorMessage(context, "Wrong username or password");
                } finally {
                  setState(() {
                    isSubmitting = false;
                  });
                }
              },
              child: isSubmitting
                  ? SizedBox(
                      height: 21,
                      width: 21,
                      child: CircularProgressIndicator(
                        color: themeData.colorScheme.background,
                      ),
                    )
                  : Text("LOGIN",
                      style: themeData.textTheme.titleLarge?.copyWith(
                          color: themeData.colorScheme.background,
                          fontSize: 18))),
          const SizedBox(
            height: 40,
          ),
          TextButton(
              onPressed: () => widget.switchForm(),
              child: const Text("Dont have an account? Tap to register")),
        ],
      ),
    );
  }
}
