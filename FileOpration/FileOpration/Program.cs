using System;

namespace FileOpration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Operations Program");
            FileOperations fo = new FileOperations();

            Console.WriteLine("\nChecking if File Exists or Not");
            fo.FileExits();

            Console.WriteLine("\nReading All Lines and Printing Lines");
            fo.ReadAllLine();

            Console.WriteLine("\nReading All text and Printing all Text");
            fo.ReadAllText();

            Console.WriteLine("\nCopying data in one file to another");
            fo.FileCopy();


            Console.WriteLine("\nDeleting File");
            fo.FileDelete();

            StreamReaderAndWriter sraw = new StreamReaderAndWriter();
            Console.WriteLine("Reading using Read Stream Reader");
            sraw.ReadlingUsingStreamReader();

            Console.WriteLine("\nWriting using Write Stream Writer");
            sraw.WritingUsingStreamWriter();

            Console.WriteLine("Binary Serialization and Deserialization ");
            BinarySerialization binarySerialization = new BinarySerialization();
            binarySerialization.Serialization();
            binarySerialization.DeSerializtion();

            Console.WriteLine("Json Serialization and Desrialization");
            JSONSerialization json = new JSONSerialization();
            json.JsonSerialize();
            json.JsonDesrialize();

            Console.WriteLine("XML Serialization");
            XMLSerialization xml = new XMLSerialization();
            xml.SerializeXml();
            xml.DeserializeXml();
        }

    }
}
