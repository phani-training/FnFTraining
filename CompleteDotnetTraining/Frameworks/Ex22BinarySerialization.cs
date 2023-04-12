using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
//Serialization is a ability to save the object itself instead of the data of the object. In this case, the object is retrived back without recreating it. It gets deserialized to the same state from which it was serialized. 
//In .NET, Serialization is performed using 4 formats: Binary, XML, SOAP and JSON. 
//Any serialization process will have 3 steps: What to serialize?,Where to serialize? and How to serialize(Format)
namespace Frameworks
{
    [Serializable]
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateOfIssue { get; set; }
    }

    interface IPersistance
    {
        void SaveData(Data data);
        List<Data> GetData();
    }

    class XmlPersistance : IPersistance
    {
        private List<Data> data = new List<Data>();
        string fileName = string.Empty;
        public XmlPersistance(string fileName) 
        {
            this.fileName = fileName;
            if (File.Exists(fileName))
            {
                GetData();
                if(data == null)
                {
                    data = new List<Data>();
                }
            }
        }

        public List<Data> GetData()
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            XmlSerializer fm = new XmlSerializer(typeof(List<Data>));
            this.data = fm.Deserialize(fs) as List<Data>;
            fs.Close();
            return this.data;
        }

        public void SaveData(Data data)
        {
            this.data.Add(data);
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer fm = new XmlSerializer(typeof(List<Data>));
            fm.Serialize(fs, this.data);
            fs.Close();
        }
    }
    class BinaryPersistance : IPersistance
    {
        private List<Data> data = new List<Data>();
        private string fileName = string.Empty;
        public BinaryPersistance(string fileName)
        {
            this.fileName = fileName;
            if (File.Exists(fileName))
            {
                GetData();
            }
            if(data == null)
            {
                data = new List<Data>();
            }
        }
        public List<Data> GetData()
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter fm = new BinaryFormatter();
            this.data = fm.Deserialize(fs) as List<Data>;
            fs.Close();
            return this.data;
        }

        public void SaveData(Data data)
        {
            this.data.Add(data);
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter fm = new BinaryFormatter();
            fm.Serialize(fs, this.data);
            fs.Close();
        }
    }

    static class PersistanceFactory
    {
        public static IPersistance GetPersistance(string arg, string fileName)
        {
            if (arg == "Binary")
                return new BinaryPersistance(fileName);
            else if (arg == "Xml")
                return new XmlPersistance(fileName);
            else if (arg == "Json")
                return new JsonPersistance();
            else
                throw new Exception("This format is not supported with us");
        }
    }
    internal class Ex22BinarySerialization
    {
        const string filePath = "Data.Bin";
        const string xmlFile = "Data.xml";
        const string menu = @"C:\Trainings\FnfTraining\Examples\CompleteDotnetTraining\Frameworks\Menu.txt";
        static IPersistance persistanceObj = null;

        static Ex22BinarySerialization()
        {
            Console.WriteLine("Enter the type of Serialization as Binary, Json or Xml");
            string format = Console.ReadLine();
            Console.WriteLine("Enter the Name of the file to create");
            string fileName = Console.ReadLine();
            persistanceObj = PersistanceFactory.GetPersistance(format, fileName);
        }
        static Data createData()
        {
            Console.WriteLine("Enter the Id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Description");
            string desc = Console.ReadLine();

            Console.WriteLine("Enter the date as dd/MM/yyyy");
            DateTime dt = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            return new Data { Id = id, Name = name, Description = desc, DateOfIssue = dt };
        }
        static void Main(string[] args)
        {
            //exampleToSerialize();
            //exampleToDeserialize();
            run();
        }

        private static void exampleToDeserialize()
        {
            BinaryFormatter fm = new BinaryFormatter();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            object data = fm.Deserialize(fs);
            if (data is Data)
            {
                Data savedObj = data as Data;
                Console.WriteLine(savedObj.Description);
            }
            fs.Close();
        }

        private static void exampleToSerialize()
        {
            var objToSave = createData();
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter fm = new BinaryFormatter();
            fm.Serialize(fs, objToSave);
            fs.Close();
        }

        static void run()
        {
            var menuContent = File.ReadAllText(menu);
            var condition = true;
            do
            {
                Console.WriteLine(menuContent);
                string choice = Console.ReadLine();
                condition = processMenu(choice);
            } while (condition);
            Console.WriteLine("Thanks for working with Us!!!!");
        }

        private static bool processMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    persistanceObj.SaveData(createData());
                    return true;
                case "2":
                    var data = persistanceObj.GetData();
                    readAllRecords(data);
                    return true;
                default:
                    return false;
            }
        }

        private static void readAllRecords(List<Data> data)
        {
            foreach(var dataItem in data)
            {
                Console.WriteLine(dataItem.Name);
            }
        }
    }
}
