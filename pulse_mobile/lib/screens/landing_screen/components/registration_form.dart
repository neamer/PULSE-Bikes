import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/user/requests/registration_request.dart';
import 'package:pulse_mobile/providers/auth/user_provider.dart';
import 'package:pulse_mobile/screens/product_search_screen.dart';

class RegistrationForm extends StatelessWidget {
  final Function switchForm;
  final Function onSuccess;

  RegistrationForm(
      {super.key, required this.switchForm, required this.onSuccess});

  final TextEditingController _usernameController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();
  final TextEditingController _firstNameController = TextEditingController();
  final TextEditingController _lastNameController = TextEditingController();
  final TextEditingController _emailController = TextEditingController();
  final TextEditingController _phoneNumberCntroller = TextEditingController();
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
            Container(
              padding: const EdgeInsets.all(8),
              decoration: const BoxDecoration(
                  border: Border(bottom: BorderSide(color: Colors.grey))),
              child: TextField(
                controller: _usernameController,
                style: themeData.textTheme.bodyMedium,
                decoration: InputDecoration(
                    border: InputBorder.none,
                    hintText: "Username",
                    hintStyle: TextStyle(color: Colors.grey[400])),
              ),
            ),
            Container(
              padding: const EdgeInsets.all(8),
              child: TextField(
                style: themeData.textTheme.bodyMedium,
                controller: _passwordController,
                decoration: InputDecoration(
                    border: InputBorder.none,
                    hintText: "Pasword",
                    hintStyle: TextStyle(color: Colors.grey[400])),
              ),
            ),
            Container(
              padding: const EdgeInsets.all(8),
              decoration: const BoxDecoration(
                  border: Border(bottom: BorderSide(color: Colors.grey))),
              child: TextField(
                controller: _firstNameController,
                style: themeData.textTheme.bodyMedium,
                decoration: InputDecoration(
                    border: InputBorder.none,
                    hintText: "First Name",
                    hintStyle: TextStyle(color: Colors.grey[400])),
              ),
            ),
            Container(
              padding: const EdgeInsets.all(8),
              decoration: const BoxDecoration(
                  border: Border(bottom: BorderSide(color: Colors.grey))),
              child: TextField(
                controller: _lastNameController,
                style: themeData.textTheme.bodyMedium,
                decoration: InputDecoration(
                    border: InputBorder.none,
                    hintText: "Last Name",
                    hintStyle: TextStyle(color: Colors.grey[400])),
              ),
            ),
            Container(
              padding: const EdgeInsets.all(8),
              decoration: const BoxDecoration(
                  border: Border(bottom: BorderSide(color: Colors.grey))),
              child: TextField(
                controller: _emailController,
                style: themeData.textTheme.bodyMedium,
                decoration: InputDecoration(
                    border: InputBorder.none,
                    hintText: "Email",
                    hintStyle: TextStyle(color: Colors.grey[400])),
              ),
            ),
            Container(
              padding: const EdgeInsets.all(8),
              decoration: const BoxDecoration(
                  border: Border(bottom: BorderSide(color: Colors.grey))),
              child: TextField(
                controller: _phoneNumberCntroller,
                style: themeData.textTheme.bodyMedium,
                decoration: InputDecoration(
                    border: InputBorder.none,
                    hintText: "Phone Number",
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
                final request = RegistrationRequest.init(
                    username: _usernameController.text,
                    password: _passwordController.text,
                    passwordConfirm: _passwordController.text,
                    firstName: _firstNameController.text,
                    lastName: _lastNameController.text,
                    email: _emailController.text,
                    phoneNumber: _phoneNumberCntroller.text);

                await _userProvider.insert(request);

                Navigator.pushNamed(
                    context, "${ProductSearchScreen.routeName}/bikes");
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
            onPressed: () => switchForm(),
            child: const Text("Already have an account? Tap here to Login")),
      ],
    );
  }
}
