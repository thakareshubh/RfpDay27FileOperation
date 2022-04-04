using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace FileOpration
{
    public class XMLSerialization
    {
        public void SerializeXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"D:\.net\Day27FileOperations\Day27FileOperations\XmlFile.txt", FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dt2 = new DateTime(2015, 12, 31);
            orderForm.OrderDate = dt2;
            ser.Serialize(fileStream, orderForm);
        }
        public void DeserializeXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"D:\.net\Day27FileOperations\Day27FileOperations\XmlFile.txt", FileMode.Open);
            OrderForm date = (OrderForm)ser.Deserialize(fileStream);
            Console.WriteLine(date.OrderDate);

        }

    }
    public class OrderForm
    {
        public DateTime OrderDate;
    }
}

