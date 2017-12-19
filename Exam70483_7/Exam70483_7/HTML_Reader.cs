using System;
using System.Net;
using System.IO;

namespace Exam70483_7
{
    class HTML_Reader : IDisposable
    {
        const string uri = "http://www.google.com";

        //Unmanaged resources
        HttpWebResponse response;
        Stream dataStream;
        StreamReader reader;

        public HTML_Reader()
        {
            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create(uri);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine("Response status description: {0}", response.StatusDescription);

            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~HTML_Reader()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Cleanup the streams and the response.
                reader.Dispose();
                dataStream.Dispose();
                response.Dispose();
            }
        }
    }
}
