using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace HoemWork9._2
{
    public class Crawler
    {
        private String current=null;
        private Hashtable urls = Hashtable.Synchronized(new Hashtable());
        private int count = 0;
        private int ready = 0;
        AutoResetEvent workDown = new AutoResetEvent(false);
        AutoResetEvent workStart = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Crawler mycrawler = new Crawler();
            String startUrl = "https://www.cnblogs.com/";
            if (args.Length >= 1) startUrl = args[0];

            mycrawler.urls.Add(startUrl, false);
            
            new Thread(mycrawler.Crawl).Start();
        }
        private void Crawl()
        {
            Console.WriteLine("开始爬取......");
            ThreadPool.SetMaxThreads(10,10);
            while (count<10)
            {
                current = null;
                if(ready<11){
                    lock (this.urls.SyncRoot)
                    {
                        foreach (String url in urls.Keys)
                        {
                            if ((bool)urls[url]) continue;
                            current = url;
                        }
                    }
                }
                
                if(current!=null&&ready<11)
                {
                    urls[current] = true;

                    Console.WriteLine("爬行" + current + "页面");
                    //Download(this);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.Download));
                    workStart.WaitOne();
                }
            }
            Console.WriteLine("爬行结束");
        }

        public void Download(object obj)
        {
            try
            {
                string currentPage = null;
                int tready;
                lock (this.urls.SyncRoot)
                {
                    currentPage = this.current;
                    urls[currentPage] = true;
                }
                tready = ready;
                ready++;
                workStart.Set();
                WebClient webCilent = new WebClient();
                webCilent.Encoding = Encoding.UTF8;
                String html = webCilent.DownloadString(currentPage);

                String fileName = tready.ToString()+".html";
                File.WriteAllText(fileName, html, Encoding.UTF8);

                urls[currentPage] = true;
                Parse(html);
                Console.WriteLine("下载完成");
                count++;
                //workStart.Set();
                workDown.Set();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                //workStart.Set();
                count++;
                workDown.Set();
            }
            
        }
        public void Parse(String html)
        {
            String strRef = @"(href|HREF)[]*=[]*[""'](https|http)[^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach(Match match in matches)
            {
                strRef=match.Value.Substring(match.Value.IndexOf('=')+1).Trim(new Char[]{ ' ', '#', '>','"'});
                    if (strRef.Length == 0) continue;
                lock (this.urls.SyncRoot) {
                    if (urls[strRef] == null) urls[strRef] = false;
                }
            }
            return;
        }
    }


}
