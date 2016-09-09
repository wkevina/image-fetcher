using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ImageFetcher
{
    struct FileInfo
    {
        public string uri;
        public Stream contents;

        public void save(string name)
        {
            using (var fs = File.Create(name))
            {
                contents.CopyTo(fs);
            }
        }
    }

    public class ResourceFetcher
    {
        private BlockingCollection<FileInfo> _resultsQ = new BlockingCollection<FileInfo>();

        public ResourceFetcher(IEnumerable<string> imgUrls, string basePath)
        {
            dispatchDownloaders(imgUrls);
            saveImages(basePath);

            _resultsQ.Dispose();
        }

        private void dispatchDownloaders(IEnumerable<string> uris)
        {
            var allTasks = new List<Task>();

            foreach (var uri in uris)
            {
                // Schedule downloader and append stream to results queue
                allTasks.Add(Task.Run(() =>
                {
                    var contents = new Downloader(uri).GetStream();

                    if (contents != null)
                    {
                        _resultsQ.Add(new FileInfo
                        {
                            uri = uri,
                            contents = contents
                        });
                    }
                }));
            }

            Task.Factory.ContinueWhenAll(allTasks.ToArray(), (_) => {
                Task.WaitAll(allTasks.ToArray());

                _resultsQ.CompleteAdding();
            });
        }

        private void saveImages(string basePath)
        {
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }

            foreach (var fileInfo in _resultsQ.GetConsumingEnumerable())
            {
                var fileUri = new Uri(fileInfo.uri);
                var path = fileUri.Segments.Last();

                fileInfo.save(Path.Combine(basePath, path));
            }
        }
    }
}