using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Searcher.Models
{
    public class ProcessingFile
    {
        public static string Read(string path)
        {
            string con = File.ReadAllText(path);
            return con;
        }
        public static void Write(string path, string con)
        {
            File.WriteAllText(path, con);
        }
        public static string Search(string str, string filter)
        {
            string result = "";
            Regex reg = new Regex(@filter);
            foreach(Match m in reg.Matches(str))
            {
                result += m.Value + '\n';
            }
            return result;
        }
    }
}
