using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Exam70483_8
{
    class HTML_Reader : IDisposable
    {
        //Resourses to dispose
        private HttpWebResponse webResponse;
        private Stream dataStream;
        private StreamReader streamReader;


        public string GetHtml(string uri = "http://www.google.com")
        {
            WebRequest webRequest = WebRequest.Create(uri);
            webRequest.Credentials = CredentialCache.DefaultCredentials;

            webResponse = (HttpWebResponse)webRequest.GetResponse();

            dataStream = webResponse.GetResponseStream();

            streamReader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = streamReader.ReadToEnd();


            return responseFromServer;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                streamReader?.Dispose();
                dataStream?.Dispose();
                webResponse?.Dispose();
            }
        }

        ~HTML_Reader()
        {
            Dispose(false);
        }
    }
}
