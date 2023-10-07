import 'package:flutter/material.dart';

import 'components/login_form.dart';
import 'components/registration_form.dart';

enum LandingScreenType { login, register }

class LandingScreen extends StatefulWidget {
  static String routeName = "/landing";

  const LandingScreen({super.key});

  @override
  State<LandingScreen> createState() => _LandingScreenState();
}

class _LandingScreenState extends State<LandingScreen> {
  LandingScreenType _type = LandingScreenType.login;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: Column(
          children: [
            const SizedBox(
              height: 60,
            ),
            FittedBox(
              child: Image.asset(
                "assets/images/logo.png",
                fit: BoxFit.fill,
              ),
            ),
            const SizedBox(
              height: 60,
            ),
            if (_type == LandingScreenType.login)
              LoginForm(
                onSuccess: () {},
                switchForm: () => {
                  setState(() {
                    _type = LandingScreenType.register;
                  })
                },
              )
            else
              RegistrationForm(
                  onSuccess: () {},
                  switchForm: () {
                    setState(() {
                      _type = LandingScreenType.login;
                    });
                  })
          ],
        ),
      ),
    );
  }
}
