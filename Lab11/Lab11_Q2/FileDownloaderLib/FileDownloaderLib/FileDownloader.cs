using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDownloaderApp
{
    delegate void DownloadCompeteHandler(int perc);
    public class FileDownloader
    {
        protected string resourceUrl;
        protected string resourceSavePath;
        internal event DownloadCompeteHandler DownLoadComplete;
        public FileDownloader(string url, string savepath)
        {
            this.resourceUrl = url;
            this.resourceSavePath = savepath;
        }
        public void DownLoadResource()
        {
            //This is just download simulation place holder code
            for (int i = 1; i <= 4; i++)
            {
                //Dummy loop to add a delay
                for (int j = 1; j <= 10000; j++)
                OnDownLoadComplete(i * 25);
            }

        }
        protected void OnDownLoadComplete(int perc)
        {
            if (DownLoadComplete != null)
                DownLoadComplete(perc);
        }

    }

}
