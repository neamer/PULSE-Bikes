import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:pulse_mobile/model/user/requests/user_update_request.dart';
import 'package:pulse_mobile/model/user/user.dart';
import 'package:pulse_mobile/providers/auth/user_provider.dart';
import 'package:pulse_mobile/utils/messages.dart';
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
                              enabled: false,
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
                        ),
                        const SizedBox(
                          height: 10,
                        ),
                        if (!isEditing)
                          OutlinedButton(
                              style: ButtonStyle(
                                  backgroundColor: MaterialStateProperty.all<
                                      Color>(Colors.white),
                                  padding: MaterialStateProperty.all(
                                      const EdgeInsets.symmetric(
                                          vertical: 20, horizontal: 30))),
                              onPressed: () => setState(() {
                                    isEditing = true;
                                  }),
                              child: Text("Edit account",
                                  style: themeData.textTheme.titleLarge
                                      ?.copyWith(
                                          color:
                                              themeData.colorScheme.background,
                                          fontSize: 18))),
                        if (isEditing)
                          Row(
                            children: [
                              OutlinedButton(
                                  style: ButtonStyle(
                                      backgroundColor:
                                          MaterialStateProperty.all<Color>(
                                              Colors.white),
                                      padding: MaterialStateProperty.all(
                                          const EdgeInsets.symmetric(
                                              vertical: 20, horizontal: 30))),
                                  onPressed: () {},
                                  child: Text("Cancel",
                                      style: themeData.textTheme.titleLarge
                                          ?.copyWith(
                                              color: themeData
                                                  .colorScheme.background,
                                              fontSize: 18))),
                              OutlinedButton(
                                  style: ButtonStyle(
                                      backgroundColor:
                                          MaterialStateProperty.all<Color>(
                                              Colors.white),
                                      padding: MaterialStateProperty.all(
                                          const EdgeInsets.symmetric(
                                              vertical: 20, horizontal: 30))),
                                  onPressed: updateAccount,
                                  child: isSubmitting
                                      ? SizedBox(
                                          height: 20,
                                          width: 20,
                                          child: CircularProgressIndicator(
                                            color: themeData
                                                .colorScheme.background,
                                          ),
                                        )
                                      : Text("Submit",
                                          style: themeData.textTheme.titleLarge
                                              ?.copyWith(
                                                  color: themeData
                                                      .colorScheme.background,
                                                  fontSize: 18)))
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

  void updateAccount() async {
    setState(() {
      isSubmitting = true;
    });
    try {
      await _provider?.updateAccount(UserUpdateRequest.init(
          firstName: _firstNameController.text,
          lastName: _lastNameController.text,
          email: _emailController.text,
          phoneNumber: _phoneNumberController.text));

      Messages.successMessage(context, "Succesfully updated profile");
    } catch (e) {
      Messages.errorMessage(
          context, "Error while performing the update request");
    } finally {
      setState(() {
        isSubmitting = false;
      });
    }
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
