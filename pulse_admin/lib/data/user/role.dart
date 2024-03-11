import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/data/abstract/base_model.dart';

part 'role.g.dart';

@JsonSerializable()
class Role extends BaseModel {
  String? name;

  Role();

  factory Role.fromJson(Map<String, dynamic> json) => _$RoleFromJson(json);

  Map<String, dynamic> toJson() => _$RoleToJson(this);
}
