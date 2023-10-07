import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/providers/auth/user_provider.dart';

import '../../../model/user/requests/login_request.dart';
import '../../../utils/util.dart';

class LoginForm extends StatelessWidget {
  final Function switchForm;
  final Function onSuccess;

  LoginForm({super.key, required this.switchForm, required this.onSuccess});

  final TextEditingController _usernameController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();

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
            Container(
              padding: const EdgeInsets.all(8),
              decoration: const BoxDecoration(
                  border: Border(bottom: BorderSide(color: Colors.grey))),
              child: TextField(
                style: themeData.textTheme.bodyMedium,
                controller: _usernameController,
                decoration: InputDecoration(
                    border: InputBorder.none,
                    hintText: "Email or phone",
                    hintStyle: TextStyle(color: Colors.grey[400])),
              ),
            ),
            Container(
              padding: const EdgeInsets.all(8),
              child: TextField(
                controller: _passwordController,
                style: themeData.textTheme.bodyMedium,
                decoration: InputDecoration(
                    border: InputBorder.none,
                    hintText: "Pasword",
                    hintStyle: TextStyle(color: Colors.grey[400])),
              ),
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
                final request = LoginRequest.init(
                    username: _usernameController.text,
                    password: _passwordController.text);

                await _userProvider.login(request);

                Authorization.username = _usernameController.text;
                Authorization.password = _passwordController.text;

                onSuccess();
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
            child: Text("LOGIN",
                style: themeData.textTheme.titleLarge?.copyWith(
                    color: themeData.colorScheme.background, fontSize: 18))),
        const SizedBox(
          height: 40,
        ),
        TextButton(
            onPressed: () => switchForm(),
            child: const Text("Dont have an account? Tap to register")),
      ],
    );
  }
}
