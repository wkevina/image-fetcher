﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                _document = new HtmlWeb().Load(_url);
            }

            var rawSrcs = _document.DocumentNode.SelectNodes("//img[@src]").Select(
                    (imgTag) => imgTag.Attributes["src"].Value);
            
            // WIP
            return rawSrcs.Select((rawSrc) =>
            {
                var srcUrl = new Uri(rawSrc);

                if (!srcUrl.IsAbsoluteUri)
                {
                    var ub = new UriBuilder();

                    return ub.Uri.ToString();
                }
                else
                {
                    return rawSrc;
                }
            });
        }
    }
}
