using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDownloaderApp
{
    class Program
    { 
        public static void Main(String[] args)
        {
            //Instantiate
            FileDownloader fd = new FileDownloader("http://www.microsoft.com/vstudio/expressv10.zip","d:\\setups");
            //Register Event Handler
            fd.DownLoadComplete += new DownloadCompeteHandler(fd_DownLoadComplete);
            //Start the task...
            fd.DownLoadResource();
            Console.ReadKey();
        }
        static void fd_DownLoadComplete(int perc)
        {
            Console.SetCursorPosition(10, 10);
            Console.Write("Downloading {0} Percent Complete", perc);
        }
    }
}
