import 'package:pulse_mobile/model/abstract/product.dart';
import 'package:pulse_mobile/model/bicycle/bicycle.dart';
import 'package:pulse_mobile/model/gear/gear.dart';
import 'package:pulse_mobile/model/part/part.dart';

class ProductUtil {
  static bool isAvailable<T extends Product>(T product) {
    if (product.discriminator == "Bicycle") {
      if ((product as Bicycle).availableSizes == null ||
          (product as Bicycle).availableSizes!.isEmpty) {
        return false;
      }

      return ((product as Bicycle)
                  .availableSizes
                  ?.map((e) => e.availableQty ?? 0)
                  .reduce((a, b) => a + b) ??
              0) >
          0;
    } else if (product.discriminator == "Gear") {
      return ((product as Gear).availableQty ?? 0) > 0;
    } else {
      return ((product as Part).availableQty ?? 0) > 0;
    }
  }
}
