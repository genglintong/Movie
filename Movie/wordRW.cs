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
            String[] oBookMark = new string[7];

            String[] Loc = local.Split('_');
            String pai = Loc[0];
            String hao = Loc[1];
            String movieName = ConfigurationManager.AppSettings["movieName"];
            String savePath = ConfigurationManager.AppSettings["savePath"];
            String date = ConfigurationManager.AppSettings["date"];
            String time = ConfigurationManager.AppSettings["time"];
            String roomNum = ConfigurationManager.AppSettings["roomNum"];
            String price = ConfigurationManager.AppSettings["price"];

            TraceHelper.GetInstance().Info("price    " + price, "WordRW Function");

            /*//赋值书签名
            oBookMark[0] = "movieName";
            oBookMark[1] = "pai";
            oBookMark[2] = "hao";
            oBookMark[3] = "roomNum";
            oBookMark[4] = "date";
            oBookMark[5] = "time";
            oBookMark[6] = "price";
            */

            String[] fieldNames = new String[] { "roomNum" , "pai" , "hao" , "movieName" , "date" , "time" , "price"};
            Object[] fieldValues = new Object[] { roomNum , pai , hao, movieName , date , time , price };

            try
            {
                //doc = wordApp.Documents.Open("D://test//test.doc");
                doc = new Aspose.Words.Document("test.doc");
                DocumentBuilder bulider = new DocumentBuilder(doc);
                
                doc.MailMerge.Execute(fieldNames, fieldValues);


                doc.Save(savePath);
                TraceHelper.GetInstance().Info("已保存至" + savePath, "WordRW Function");

                //打印
                doc = new Document(savePath);
                doc.Print();
                TraceHelper.GetInstance().Info("文件已打印", "WordRW Function");

                //bulider.MoveToBookmark(oBookMark[0]);
                //bulider.Write(movieName);
                /*bulider.MoveToBookmark(oBookMark[1]);
                bulider.Write(pai);
                bulider.MoveToBookmark(oBookMark[2]);
                bulider.Write(hao);
                bulider.MoveToBookmark(oBookMark[3]);
                bulider.Write(roomNum);
                bulider.MoveToBookmark(oBookMark[4]);
                bulider.Write(date);
                bulider.MoveToBookmark(oBookMark[5]);
                bulider.Write(time);
                bulider.MoveToBookmark(oBookMark[6]);
                bulider.Write(price);*/

                //清空标识
                //doc.Range.Bookmarks[oBookMark[0]].Text = movieName;
                /* doc.Range.Bookmarks[oBookMark[1]].Text = pai;
                 doc.Range.Bookmarks[oBookMark[2]].Text = "";
                 doc.Range.Bookmarks[oBookMark[3]].Text = "";
                 doc.Range.Bookmarks[oBookMark[4]].Text = "";
                 doc.Range.Bookmarks[oBookMark[5]].Text = "";
                 doc.Range.Bookmarks[oBookMark[6]].Text = "";*/


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
