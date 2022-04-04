using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOpration
{
    public class FileOperations
    {
        /// <summary>
        /// Files the exits.
        /// </summary>
        public void FileExits()
        {
            string path = @"E:\.net\RfpDay27FileOperation\FileOpration\FileOpration\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
            Console.ReadKey();

        }
        /// <summary>
        /// Reads all line.
        /// </summary>
        public void ReadAllLine()
        {
            string path = @"E:\.net\RfpDay27FileOperation\FileOpration\FileOpration\Example.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            foreach (var l in lines)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Reads all text.
        /// </summary>
        public void ReadAllText()
        {
            string path = @"E:\.net\RfpDay27FileOperation\FileOpration\FileOpration\Example.txt";

            string lines = File.ReadAllText(path);
            Console.WriteLine(lines);

            Console.ReadKey();
        }
        /// <summary>
        /// Files the copy.
        /// </summary>
        public void FileCopy()
        {
            string path = @"E:\.net\RfpDay27FileOperation\FileOpration\FileOpration\Example.txt";
            string copypath = @"E:\.net\RfpDay27FileOperation\FileOpration\FileOpration\Example.txt";
            File.Copy(path, copypath);
            Console.ReadKey();

        }
        /// <summary>
        /// Files the delete.
        /// </summary>
        public void FileDelete()
        {
            string path = @"E:\.net\RfpDay27FileOperation\FileOpration\FileOpration\Example.txt";
            File.Delete(path);

            Console.ReadKey();
        }

    }
}
