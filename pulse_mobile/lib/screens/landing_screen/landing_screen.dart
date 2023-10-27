import 'package:flutter/material.dart';
import 'package:pulse_mobile/screens/product_search_screen.dart';

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

  void onSuccess() =>
      Navigator.pushNamed(context, "${ProductSearchScreen.routeName}/bikes");

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: Column(
          children: [
            const SizedBox(
              height: 60,
            ),
            SizedBox(
              height: 60,
              width: double.infinity,
              child: FittedBox(
                child: Image.asset(
                  "assets/images/logo.png",
                  fit: BoxFit.fill,
                ),
              ),
            ),
            const SizedBox(
              height: 60,
            ),
            if (_type == LandingScreenType.login)
              LoginForm(
                onSuccess: onSuccess,
                switchForm: () => {
                  setState(() {
                    _type = LandingScreenType.register;
                  })
                },
              )
            else
              RegistrationForm(
                  onSuccess: onSuccess,
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
