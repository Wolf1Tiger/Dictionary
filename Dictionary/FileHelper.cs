using System;
using System.IO;

namespace Dictionary
{
    class FileHelper
    {
        private string path = @"C:\Users\hp\source\repos\Dictionary\Dictionary\Languages";
        public string[] GetLanguagesFromFile()
        {
            string[] languages = File.ReadAllLines(Path.Combine(path,"languages.txt"));
            return languages;
        }
        public string Translate(string from,string to,string word)
        {
           
                string s = "not faund";
                int fromIndex, toIndex;
                using (StreamReader reader = new StreamReader(TranslatePath(from, to)))
                {
                    string line;
                    line = reader.ReadLine();
                    if (line.Split()[0] == from)
                    {
                        fromIndex = 0;
                        toIndex = 1;
                    }
                    else
                    {
                        fromIndex = 1;
                        toIndex = 0;
                    }
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] ss = line.Split();
                        if (word.Equals(ss[fromIndex]))
                        {
                            s = ss[toIndex];
                            break;
                        }
                    }
                }

            return s;       
        }
         
        public void WriteWordToFile(string from,string to,string l1,string l2)
        {
            File.AppendAllText(Path.Combine(path, from + "-" + to + ".txt"),Environment.NewLine+ l1 + " " + l2);
        }
        public string TranslatePath(string from,string to)
        {
            string path1 = Path.Combine(path, from + "-" + to + ".txt");
            string path2 = Path.Combine(path, to + "-" + from + ".txt");

            if (File.Exists(path1))
            {
                return path1;
            }
            else
            {
                return path2;
            }
        }
    }
}
