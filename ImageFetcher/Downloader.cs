using System;
using System.Net;
using System.IO;

namespace ImageFetcher
{
    public class Downloader
    {
        private string _path;

        public Downloader(string path)
        {
            _path = path;
        }

        public Stream GetStream()
        {
            var req = WebRequest.Create(_path);
            req.Proxy = null;
            try
            {
                using (var res = (HttpWebResponse)req.GetResponse())
                using (var responseStream = res.GetResponseStream())
                {
                    MemoryStream memoryStream = new MemoryStream();

                    responseStream.CopyTo(memoryStream);

                    // Reset seek position for caller
                    memoryStream.Position = 0;

                    return memoryStream;
                }
            } catch (WebException ex404) {
                Console.WriteLine(String.Format("Cannot fetch resource at {0}", _path));

                return null;
            }
        }
    }
}
