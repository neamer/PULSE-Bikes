import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_mobile/model/abstract/base_model.dart';
import 'package:pulse_mobile/model/part/part.dart';

part 'servicing_part.g.dart';

@JsonSerializable()
class ServicingPart extends BaseModel {
  int? servicingId;
  int? productId;
  double? unitPrice;
  int? quantity;

  Part? product;

  ServicingPart();

  factory ServicingPart.fromJson(Map<String, dynamic> json) =>
      _$ServicingPartFromJson(json);

  Map<String, dynamic> toJson() => _$ServicingPartToJson(this);
}
