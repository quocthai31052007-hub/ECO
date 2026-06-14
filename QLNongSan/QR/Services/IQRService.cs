using System;
using System.Collections.Generic;
using System.Text;

namespace QLNongSan.QR.Services
{
    public interface IQRService
    {
        public Dictionary<string, string> ProcessQRFile(string filename);

        public void CreateQRFile(Dictionary<string, string> input, string filename);
    }
}
