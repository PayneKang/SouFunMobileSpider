using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SouFunMobileSpider.Client
{
    public sealed class FileReader
    {
        public static String ReadFile(string filepath)
        {
            FileStream fs = new FileStream(filepath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            //开始读
            String str = sr.ReadToEnd();
            //清空缓冲区
            //关闭流
            sr.Close();
            fs.Close();
            return str;
        }
    }
}
