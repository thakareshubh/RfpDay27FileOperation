using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOpration
{
    public class StreamReaderAndWriter
    {
        /// <summary>
        /// Writings the using stream writer.
        /// </summary>
        public void WritingUsingStreamWriter()
        {
            string path = @"D:\.net\Day27FileOperations\Day27FileOperations\StreamWriterdemo.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Hello World - .net is Awesome ");
                sw.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Readlings the using stream reader.
        /// </summary>
        public void ReadlingUsingStreamReader()
        {
            string path = @"D:\.net\Day27FileOperations\Day27FileOperations\StreamWriterdemo.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                string s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();

        }
    }
}
