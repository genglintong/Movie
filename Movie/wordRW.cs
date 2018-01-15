using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;
using LogLib;

namespace Movie
{
    class wordRW
    {
        public static String readWord(String local)
        {
            StringBuilder sb = new StringBuilder();
            //Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document doc = null;

            object unknow = System.Reflection.Missing.Value;
            Console.WriteLine("test");
            String[] oBookMark = new string[5];

            String[] Loc = local.Split('_');
            String pai = Loc[0];
            String hao = Loc[1];
            String movieName = ConfigurationManager.AppSettings["movieName"];
            String savePath = ConfigurationManager.AppSettings["savePath"];

            //赋值书签名
            oBookMark[0] = "movieName";
            oBookMark[1] = "pai";
            oBookMark[2] = "pai1";
            oBookMark[3] = "hao";
            oBookMark[4] = "hao1";

            try
            {
                //doc = wordApp.Documents.Open("D://test//test.doc");
                doc = new Aspose.Words.Document("test.doc");
                DocumentBuilder bulider = new DocumentBuilder(doc);

                bulider.MoveToBookmark(oBookMark[0]);
                bulider.Write(movieName);
                bulider.MoveToBookmark(oBookMark[1]);
                bulider.Write(pai);
                bulider.MoveToBookmark(oBookMark[2]);
                bulider.Write(pai);
                bulider.MoveToBookmark(oBookMark[3]);
                bulider.Write(hao);
                bulider.MoveToBookmark(oBookMark[4]);
                bulider.Write(hao);

                doc.Save(savePath);
                TraceHelper.GetInstance().Info("已保存至" + savePath, "WordRW Function");

                /*int paragraphsCount = doc.Paragraphs.Count;

                doc.Bookmarks.get_Item(ref oBookMark[0]).Range.Text = movieName;
                doc.Bookmarks.get_Item(ref oBookMark[1]).Range.Text = pai;
                doc.Bookmarks.get_Item(ref oBookMark[2]).Range.Text = pai;
                doc.Bookmarks.get_Item(ref oBookMark[3]).Range.Text = hao;
                doc.Bookmarks.get_Item(ref oBookMark[4]).Range.Text = hao;

                doc.SaveAs2(savePath);
                TraceHelper.GetInstance().Info("已保存至" + savePath, "WordRW Function");

                doc.Close(ref unknow, ref unknow, ref unknow);
                wordApp.Documents.Save(ref unknow, ref unknow);
                wordApp.Quit(ref unknow, ref unknow, ref unknow);*/
            }
            catch
            {
                TraceHelper.GetInstance().Error("发生错误", "WordRW Function");
            }
            //Console.WriteLine( sb.ToString());
            return "";
        }
    }
}
