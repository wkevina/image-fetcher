using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using ImageFetcher;

namespace ImageFetcherTests
{
    [TestClass]
    public class DownloaderTests
    {
        [TestMethod]
        public void TestDownloadResource()
        {
            var netPath = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/66/SMPTE_Color_Bars.svg/2000px-SMPTE_Color_Bars.svg.png";

            var downloader = new Downloader(netPath);

            using (Stream imageStream = downloader.GetStream())
            {
                Assert.IsNotNull(imageStream);
                Assert.IsTrue(imageStream.CanRead);
                Assert.IsTrue(imageStream.Length > 0);
            }
        }
    }
}
