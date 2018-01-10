using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Exam70483_10
{
    class ImageLoader
    {
        /// <summary>
        /// Download Image stream from given url
        /// </summary>
        /// <param name="url">url from which image stream should be downloaded</param>
        /// <returns>return byte array of image stream downloaded</returns>
        public static byte[] DownloadImageStream(string url = @"http://s3-eu-west-1.amazonaws.com/pravdasevera/9bhucv08/w45p.jpg")
        {
            WebClient client = new WebClient();

            byte[] imageData = client.DownloadData(url);

            return imageData;
        }
    }
}
