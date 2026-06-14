using System.Drawing;
using ZXing.Windows.Compatibility;


namespace QLNongSan.QR.Services
{

    public class QRService : IQRService
    {
        public required string basename;
        public required string absolutePath;

        public Dictionary<string, string> ProcessQRFile(string filename)
        {
            var qrDecoder = new BarcodeReader();
            var qrBitmap = (Bitmap)Image.FromFile(filename);
            var result = qrDecoder.Decode(qrBitmap);
            var url = new Uri(result.Text);
            if (url.Host != basename)
            {
                throw new Exception("Mã QR không hợp lệ. Vui lòng thử lại với một mã QR khác.");
            }
            if (url.AbsolutePath != absolutePath)
            {
                throw new Exception("Mã QR không hợp lệ. Vui lòng thử lại với một mã QR khác.");
            }
            var queryParams = System.Web.HttpUtility.ParseQueryString(url.Query);
            var queryParamsDict = queryParams.AllKeys.ToDictionary((key) =>
            {
                return key ?? throw new Exception("key not found");
            }, (key) =>
            {
                return queryParams[key] ?? "";
            });
            return queryParamsDict;
        }

        public void CreateQRFile(Dictionary<string, string> data, string filename)
        {
            var qrEncoder = new BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 300,
                    Width = 300,
                    Margin = 1
                }
            };
            var qsCollection = System.Web.HttpUtility.ParseQueryString(string.Empty);
            foreach (var key in data.Keys)
            {
                qsCollection.Add(key, data[key]);
            }
            var url = new UriBuilder
            {
                Scheme = "https",
                Host = basename,
                Path = absolutePath,
                Query = qsCollection.ToString()
            }.Uri.ToString();
            qrEncoder.Write(url).Save(filename, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
