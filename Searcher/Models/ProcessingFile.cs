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
        public static string ReadFile(string path)
        {
            string content = File.ReadAllText(path);
            return content;
        }
        public static void WriteFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }
        public static string SearchByFilter(string str, string filter)
        {
            string result = "";
            Regex regex = new Regex(@filter);
            foreach(Match match in regex.Matches(str))
            {
                result += match.Value + '\n';
            }
            return result;
        }
    }
}
