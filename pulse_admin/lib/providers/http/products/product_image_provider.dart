import 'package:pulse_admin/data/product_image/product_image.dart';
import 'package:pulse_admin/providers/http/base/base_crud_provider.dart';

class ProductImageProvider extends BaseCRUDProvider<ProductImage> {
  ProductImageProvider() : super('ProductImage');

  @override
  ProductImage fromJson(data) {
    return ProductImage.fromJson(data);
  }
}
