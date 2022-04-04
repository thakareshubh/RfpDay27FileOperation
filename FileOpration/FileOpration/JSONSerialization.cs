using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileOpration
{
    public class JSONSerialization
    {
        public void JsonSerialize()
        {
            Blogsites bsObj = new Blogsites()
            {
                Name = "Manoj",
                Description = "23 yr old Male"
            };
            //Converting Blogsite object to Jason string format
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
        }
        public void JsonDesrialize()
        {
            string json = @"{ 'Name' : 'Manoj',
                               'Description' : '23 yr old Male'}";
            Blogsites bsobj = JsonConvert.DeserializeObject<Blogsites>(json);
            Console.WriteLine(bsobj.Name);

        }
        [DataContract]
        class Blogsites
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string Description { get; set; }

        }
    }
}
