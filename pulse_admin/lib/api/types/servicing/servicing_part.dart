import 'package:json_annotation/json_annotation.dart';
import 'package:pulse_admin/api/types/abstract/base_model.dart';
import 'package:pulse_admin/api/types/part/part.dart';

part 'servicing_part.g.dart';

@JsonSerializable()
class ServicingPart extends BaseModel {
  int? servicingId;
  int? productId;
  double? unitPrice;
  int? quantity;

  Part? product;

  ServicingPart();

  ServicingPart.fromPart(Part source) {
    quantity = 1;
    product = source;
    productId = source.id;
    unitPrice = source.price;
  }

  factory ServicingPart.fromJson(Map<String, dynamic> json) =>
      _$ServicingPartFromJson(json);

  Map<String, dynamic> toJson() => _$ServicingPartToJson(this);
}
