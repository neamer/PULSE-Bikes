import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_admin/api/providers/auth/auth_provider.dart';
import 'package:pulse_admin/api/types/user/requests/login_request.dart';
import 'package:pulse_admin/components/atoms/buttons/button.dart';
import 'package:pulse_admin/components/molecules/form/text_form_field_group.dart';
import 'package:pulse_admin/core/http/request_handler.dart';
import 'package:pulse_admin/core/http/request_state.dart';
import 'package:pulse_admin/core/layout/layout.dart';
import 'package:pulse_admin/core/style/colors.dart';

class LoginPage extends StatefulWidget {
  static const String route = '/login';

  const LoginPage({super.key});

  @override
  State<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  RequestState _submitState = RequestState.init;

  final TextEditingController usernameController = TextEditingController();

  final TextEditingController passwordController = TextEditingController();

  Future login() async {
    try {
      setState(() {
        _submitState = RequestState.loading;
      });

      await context.read<AuthProvider>().login(LoginRequest.init(
          username: usernameController.value.text,
          password: passwordController.value.text));

      setState(() {
        _submitState = RequestState.success;
      });

      // ignore: use_build_context_synchronously
      Navigator.pushReplacementNamed(context, Layout.route);
    } catch (e) {
      setState(() {
        _submitState = RequestState.error;
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
          height: 430,
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
              TextFormFieldGroup(
                label: "Username",
                controller: usernameController,
              ),
              const SizedBox(
                height: 20,
              ),
              TextFormFieldGroup(
                label: "Password",
                controller: passwordController,
                obscureText: true,
              ),
              const SizedBox(
                height: 50,
              ),
              SizedBox(
                width: double.infinity,
                child: Button(
                  loading: _submitState == RequestState.loading,
                  onClick: genericErrorHandler(context, login),
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
