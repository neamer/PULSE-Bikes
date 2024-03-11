import 'package:flutter/material.dart';
import 'package:pulse_admin/core/layout/layout.dart';
import 'package:pulse_admin/core/style/theme_data.dart';
import 'package:pulse_admin/pages/login_page.dart';
import 'package:pulse_admin/providers/http/http_multi_provider.dart';
import 'package:window_size/window_size.dart';

void main() {
  WidgetsFlutterBinding.ensureInitialized();

  setWindowMinSize(const Size(1280, 720));

  runApp(const App());
}

class App extends StatelessWidget {
  const App({super.key});

  @override
  Widget build(BuildContext context) {
    return HttpMultiProvider(
        child: MaterialApp(
      title: 'PULSE Admin',
      theme: PulseTheme.themeData,
      initialRoute: LoginPage.route,
      routes: {
        LoginPage.route: (_) => const LoginPage(),
        Layout.route: (_) => const Layout()
      },
    ));
  }
}
