import 'package:flutter/material.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class ListItemBase extends StatefulWidget {
  final List<Widget> children;
  final List<Widget>? actions;
  final VoidCallback? onClick;

  const ListItemBase({
    Key? key,
    required this.children,
    this.actions,
    this.onClick,
  }) : super(key: key);

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
          onTap: widget.onClick,
          child: Container(
            decoration: BoxDecoration(
              color: isHovered ? ColorTheme.m600 : ColorTheme.m700,
              borderRadius: BorderRadius.circular(Spacing.sm),
            ),
            child: Stack(
              children: [
                Padding(
                  padding: const EdgeInsets.symmetric(
                      horizontal: Spacing.lg, vertical: Spacing.lg),
                  child: Row(
                    children: widget.children,
                  ),
                ),
                if (isHovered && widget.actions != null)
                  Positioned(
                    top: 0,
                    right: 0,
                    bottom: 0,
                    child: Row(
                      children: [
                        Container(
                          width: 40,
                          decoration: const BoxDecoration(
                            gradient: LinearGradient(
                              begin: Alignment.centerLeft,
                              end: Alignment.centerRight,
                              colors: [ColorTheme.m600, ColorTheme.m600],
                            ),
                          ),
                        ),
                        Container(
                          color: ColorTheme.m600,
                          child: Padding(
                            padding: const EdgeInsets.symmetric(
                                horizontal: Spacing.md),
                            child: Row(
                              mainAxisSize: MainAxisSize.min,
                              children: widget.actions!,
                            ),
                          ),
                        ),
                      ],
                    ),
                  ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
