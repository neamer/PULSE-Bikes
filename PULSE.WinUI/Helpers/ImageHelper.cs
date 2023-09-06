using System.Drawing.Imaging;

namespace PULSE.WinUI.Helpers
{
    public class ImageHelper
    {

        public static byte[] FromImageToByte(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public static Image FromByteToImage(byte[] image)
        {
            var ms = new MemoryStream(image);
            return Image.FromStream(ms);

        }


    }
}
