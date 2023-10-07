import 'base_model.dart';

class AuditableModel extends BaseModel {
  DateTime? createdAt;
  DateTime? updatedAt;

  AuditableModel();
}
