import 'package:flutter/material.dart';
import 'package:pulse_admin/layout/layout.dart';
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
    return MaterialApp(
      title: 'Flutter Desktop App',
      theme: ThemeData(
          //backgroundColor: Color.fromRGBO(39, 39, 49, 1),
          primaryColor: const Color.fromRGBO(188, 188, 188, 1),
          scaffoldBackgroundColor: const Color.fromRGBO(19, 19, 29, 1),
          buttonTheme: ThemeData.light().buttonTheme.copyWith(),
          textTheme: ThemeData.light().textTheme.copyWith(
              titleLarge: const TextStyle(
                  fontSize: 24,
                  fontWeight: FontWeight.bold,
                  color: Colors.white),
              titleSmall: const TextStyle(
                  fontSize: 16, color: Color.fromRGBO(188, 188, 188, 1)),
              displayMedium: const TextStyle(
                  fontSize: 18,
                  fontWeight: FontWeight.bold,
                  color: Colors.white),
              bodyLarge: const TextStyle(
                  fontSize: 18,
                  fontWeight: FontWeight.w300,
                  color: Color.fromRGBO(188, 188, 188, 1)),
              bodyMedium: const TextStyle(
                  fontSize: 16,
                  fontWeight: FontWeight.w300,
                  color: Color.fromRGBO(188, 188, 188, 1))),
          appBarTheme: const AppBarTheme(
              backgroundColor: Color.fromRGBO(19, 19, 29, 1),
              foregroundColor: Colors.white),
          colorScheme: ColorScheme.fromSwatch()
              .copyWith(
                  primary: Colors.white,
                  primaryContainer: const Color.fromRGBO(188, 188, 188, 1),
                  secondary: Colors.cyan,
                  background: const Color.fromRGBO(19, 19, 29, 1),
                  outline: const Color.fromRGBO(43, 43, 62, 1))
              .copyWith(background: const Color.fromRGBO(19, 19, 29, 1))),
      home: const Scaffold(
        body: Layout(),
      ),
    );
  }
}
