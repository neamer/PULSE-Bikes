import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/molecules/form/text_form_group.dart';
import 'package:pulse_admin/core/http/fetch_state.dart';
import 'package:pulse_admin/core/layout/layout.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/data/user/requests/login_request.dart';
import 'package:pulse_admin/providers/http/auth_provider.dart';

class LoginPage extends StatefulWidget {
  static const String route = '/login';

  const LoginPage({super.key});

  @override
  State<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  FetchState _submitState = FetchState.init;

  final TextEditingController usernameController = TextEditingController();

  final TextEditingController passwordController = TextEditingController();

  void login() async {
    try {
      setState(() {
        _submitState = FetchState.loading;
      });

      await context.read<AuthProvider>().login(LoginRequest.init(
          username: usernameController.value.text,
          password: passwordController.value.text));

      setState(() {
        _submitState = FetchState.success;
      });

      // ignore: use_build_context_synchronously
      Navigator.pushReplacementNamed(context, Layout.route);
    } catch (e) {
      setState(() {
        _submitState = FetchState.error;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Material(
      child: Container(
        color: ColorTheme.m800,
        child: Center(
            child: SizedBox(
          width: 300,
          height: 400,
          child: Column(
            children: [
              SizedBox(
                height: 90,
                width: 150,
                child: FittedBox(
                  child: Image.asset(
                    "assets/images/logo.png",
                    fit: BoxFit.contain,
                  ),
                ),
              ),
              const SizedBox(
                height: 30,
              ),
              TextFormGroup(
                label: "Username",
                controller: usernameController,
              ),
              const SizedBox(
                height: 20,
              ),
              TextFormGroup(
                label: "Password",
                controller: passwordController,
              ),
              const SizedBox(
                height: 50,
              ),
              SizedBox(
                width: double.infinity,
                child: Button(
                  loading: _submitState == FetchState.loading,
                  onClick: login,
                  text: "LOGIN",
                ),
              )
            ],
          ),
        )),
      ),
    );
  }
}
