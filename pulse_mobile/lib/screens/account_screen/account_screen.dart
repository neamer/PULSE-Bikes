import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/user/user.dart';
import 'package:pulse_mobile/providers/auth/user_provider.dart';
import 'package:pulse_mobile/widgets/basic_text_field.dart';
import 'package:pulse_mobile/widgets/global_navigation_drawer.dart';

class AccountScreen extends StatefulWidget {
  static String routeName = "/account";

  const AccountScreen({super.key});

  @override
  State<AccountScreen> createState() => _AccountScreenState();
}

class _AccountScreenState extends State<AccountScreen> {
  bool _loading = false;
  bool isSubmitting = false;
  bool isEditing = false;

  final TextEditingController _usernameController = TextEditingController();

  final TextEditingController _firstNameController = TextEditingController();

  final TextEditingController _lastNameController = TextEditingController();

  final TextEditingController _emailController = TextEditingController();

  final TextEditingController _phoneNumberController = TextEditingController();

  UserProvider? _provider;
  User? _data;

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return Scaffold(
        drawer: const SafeArea(child: Drawer(child: GlobalNavigationDrawer())),
        appBar: AppBar(
          title: Image.asset(
            "assets/images/logo.png",
            fit: BoxFit.contain,
            height: 50,
          ),
          toolbarHeight: 75,
          centerTitle: true,
          shape: const Border(bottom: BorderSide(color: Colors.cyan, width: 1)),
        ),
        body: _loading
            ? const Center(
                child: Padding(
                padding: EdgeInsets.all(20),
                child: CircularProgressIndicator(),
              ))
            : SingleChildScrollView(
                child: Padding(
                  padding: const EdgeInsets.symmetric(
                      horizontal: 20.0, vertical: 30),
                  child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          "ACCOUNT",
                          style: Theme.of(context).textTheme.titleLarge,
                        ),
                        const SizedBox(
                          height: 10,
                        ),
                        Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            BasicTextField(
                              name: "Username",
                              controller: _usernameController,
                              enabled: isEditing,
                            ),
                            BasicTextField(
                              name: "First name",
                              controller: _firstNameController,
                              enabled: isEditing,
                            ),
                            BasicTextField(
                              name: "Last name",
                              controller: _lastNameController,
                              enabled: isEditing,
                            ),
                            BasicTextField(
                              name: "Email",
                              controller: _emailController,
                              enabled: isEditing,
                            ),
                            BasicTextField(
                              name: "Phone number",
                              controller: _phoneNumberController,
                              enabled: isEditing,
                            ),
                          ],
                        )
                      ]),
                ),
              ));
  }

  @override
    void initState() {
      super.initState();

      _provider = context.read<UserProvider>();
      loadData();
    }

  Future loadData() async {
    setState(() {
      _loading = true;
    });
    var tmpData = await _provider?.me();
    setState(() {
      _data = tmpData;
      _loading = false;
      _usernameController.text = _data?.username ?? "";
      _firstNameController.text = _data?.firstName ?? "";
      _lastNameController.text = _data?.lastName ?? "";
      _emailController.text = _data?.email ?? "";
      _phoneNumberController.text = _data?.phoneNumber ?? "";
    });
  }
}
