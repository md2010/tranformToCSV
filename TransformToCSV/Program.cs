using System;
using System.IO;
using System.Text;

namespace TransformToCSV 
{
    class Program
    {       
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Martina\Documents\Other\Diplomski\1. godina\RUAP\Projekt\SMSSpamCollection.txt";
            string newFilePath = @"C:\Users\Martina\Documents\Other\Diplomski\1. godina\RUAP\Projekt\SMSSpamCollection.csv";           
            using (StreamReader sr = new StreamReader(path))
            using (var sw = new StreamWriter(newFilePath))
            {
                string Line;
                while ((Line = sr.ReadLine()) != null)
                {
                    int i = 0;
                    

                    StringBuilder sb = new StringBuilder();
                    sb.Append(Line);

                    while (i < Line.Length)
                    {
                        char s = sb[i];
                        if (s == '\t')
                        {
                            sb.Replace('\t', ',', i, 1);
                            i++;                           
                        }

                        if(s == ',')
                        {
                            sb.Replace(',', ' ', i, 1);                            
                        }
                        i++;                      
                    }                 
                    sw.Write(sb.ToString(), i, 1);
                    sw.Write("\n");
                }
            } 
        }
    }
}