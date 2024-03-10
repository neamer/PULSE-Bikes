import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class ListItemBase extends StatefulWidget {
  final List<Widget> children;

  const ListItemBase({Key? key, required this.children}) : super(key: key);

  @override
  State<StatefulWidget> createState() => _ListItemBaseState();
}

class _ListItemBaseState extends State<ListItemBase> {
  bool isHovered = false;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.only(bottom: Spacing.md),
      child: MouseRegion(
        onEnter: (event) {
          setState(() {
            isHovered = true;
          });
        },
        onExit: (event) {
          setState(() {
            isHovered = false;
          });
        },
        child: InkWell(
          customBorder: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(Spacing.sm),
          ),
          onTap: () {},
          child: Container(
            decoration: BoxDecoration(
              color: isHovered ? ColorTheme.m600 : ColorTheme.m700,
              borderRadius: BorderRadius.circular(
                  Radius.sm), // Adjust the radius as needed
            ),
            child: Padding(
              padding: const EdgeInsets.symmetric(
                  horizontal: Spacing.lg, vertical: Spacing.lg),
              child: Row(
                children: widget.children,
              ),
            ),
          ),
        ),
      ),
    );
  }
}
