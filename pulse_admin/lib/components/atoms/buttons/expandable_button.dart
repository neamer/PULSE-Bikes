import 'package:flutter/material.dart';
import 'package:pulse_admin/components/molecules/spacing/spaced_column.dart';
import 'package:pulse_admin/core/style/colors.dart';
import 'package:pulse_admin/core/style/spacing.dart';

class ExpandableButton extends StatefulWidget {
  const ExpandableButton(this.text, {Key? key, required this.children})
      : super(key: key);

  final String text;
  final List<Widget> children;

  @override
  State<ExpandableButton> createState() => _ExpandableButtonState();
}

class _ExpandableButtonState extends State<ExpandableButton> {
  bool isHovered = false;
  final ExpansionTileController _expansionTileController =
      ExpansionTileController();

  @override
  Widget build(BuildContext context) {
    var themeData = Theme.of(context);

    return ClipRRect(
      borderRadius: BorderRadius.circular(Radius.xs),
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
        child: Container(
          color: isHovered && !_expansionTileController.isExpanded
              ? ColorTheme.m600.withAlpha(150)
              : ColorTheme.m750,
          width: double.infinity,
          child: ExpansionTile(
              shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(Radius.xs),
                  side: BorderSide.none),
              onExpansionChanged: (_) => setState(() {}),
              controller: _expansionTileController,
              title: Text(
                widget.text,
                style: themeData.textTheme.titleSmall,
              ),
              iconColor: ColorTheme.n500, // Customize icon color
              childrenPadding: const EdgeInsets.all(Spacing.xs),
              tilePadding: const EdgeInsets.symmetric(
                horizontal: Spacing.lg,
              ),
              collapsedTextColor:
                  ColorTheme.n500, // Customize collapsed text color
              collapsedIconColor:
                  ColorTheme.n500, // Customize collapsed icon color
              // backgroundColor:
              //     isHovered ? ColorTheme.m500.withAlpha(150) : ColorTheme.m750,
              // collapsedBackgroundColor:
              //     isHovered ? ColorTheme.m500.withAlpha(150) : ColorTheme.m750,
              children: [
                SpacedColumn(
                    spacing: Spacing.sm,
                    children: widget.children
                        .map(
                          (item) => SizedBox(
                            width: double.infinity,
                            child: item,
                          ),
                        )
                        .toList()),
              ]),
        ),
      ),
    );
  }
}
