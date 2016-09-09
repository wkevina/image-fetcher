using System;
using ImageFetcher;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Missing URL argument");
            Environment.Exit(1);
        }

        var targetUrl = args[0];

        var basePath = args.Length >= 2 ? args[1] : ".";

        new ResourceFetcher(new ImageScraper(targetUrl).getImageUrls(), basePath);
    }
}

