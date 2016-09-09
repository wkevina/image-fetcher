using System;
using System.Linq;
using System.Collections.Generic;
using HtmlAgilityPack;

namespace ImageFetcher
{
    class ImageScraper
    {
        private string _url;
        private HtmlDocument _document;

        public ImageScraper(string url)
        {
            _url = url;
        }

        public IEnumerable<string> getImageUrls()
        {
            if (_document == null)
            {
                var htmlWeb = new HtmlWeb();
                _document = htmlWeb.Load(_url);
                // update url to the resource that actually responded to the request
                _url = htmlWeb.ResponseUri.AbsoluteUri;
            }

            var tags = _document.DocumentNode.SelectNodes("//img[@src]") ?? new HtmlNodeCollection(_document.DocumentNode);

            var rawSrcs = from tag in tags
                          select tag.Attributes["src"].Value;

            return rawSrcs.Select(rawSrc =>
            {
                Uri srcUrl;

                if (Uri.TryCreate(rawSrc, UriKind.RelativeOrAbsolute, out srcUrl))
                {
                    if (!srcUrl.IsAbsoluteUri)
                    {
                        return new Uri(new Uri(_url), srcUrl).AbsoluteUri;
                    }
                    else
                    {
                        return rawSrc;
                    }
                }
                else
                {
                    return null;
                }

            });
        }
    }
}
