using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
//JSON serialization is a new feature of Serialization, it's packages should be added to the Project and then used. 
namespace Frameworks
{

    class JsonPersistance : IPersistance
    {
        private List<Data> _data = new List<Data>();
        public List<Data> GetData()
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            StreamReader reader = new StreamReader("Data.json");
            this._data = jsonSerializer.Deserialize(reader, typeof(List<Data>)) as List<Data>;
            reader.Close();
            return _data;
        }

        public void SaveData(Data data)
        {
            if(_data == null)
            {
                _data = new List<Data>();
            }
            _data.Add(data);
            JsonSerializer jsonSerializer = new JsonSerializer();
            StreamWriter writer = new StreamWriter("Data.json");
            jsonSerializer.Serialize(writer, _data, typeof(List<Data>));
            writer.Close();
        }
    }

    internal class Ex23JsonSerialization
    {
        static void Main(string[] args)
        {
            IPersistance persistance = new JsonPersistance();
            persistance.SaveData(new Data
            {
                Id = 101, DateOfIssue = DateTime.Parse("12/12/2004"), Description="Details of a Training Program", Name="Training on .NET"
            });

            var data = persistance.GetData();
            foreach(var dataItem in data)
                Console.WriteLine(dataItem.Name);
        }
    }
}
//Assignment: Try an example of SOAP Serialization....