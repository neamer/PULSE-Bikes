import 'package:pulse_admin/api/providers/base/base_crud_provider.dart';
import 'package:pulse_admin/api/types/product_image/product_image.dart';

class ProductImageProvider extends BaseCRUDProvider<ProductImage> {
  ProductImageProvider() : super('ProductImage');

  @override
  ProductImage fromJson(data) {
    return ProductImage.fromJson(data);
  }
}
