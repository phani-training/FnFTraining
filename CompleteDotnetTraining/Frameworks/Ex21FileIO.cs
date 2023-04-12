using Frameworks.Models;
using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Security;
//U can write to Physical files, create new directories, copy contents of one directory to another, delete existing directories, write text, binary files and read from them. 
//File IO is based on Streams. Streams are contegenous memory which has a flow of data from source to destination. 
//Anything that comes to UR Application is called InputStream and the one that comes out of UR Application is called OutputStream.
//FileStream is a class that allows to stream the data to a physical File. It is used to write any kind of file(Text or Binary).
//There is a static class called File that will allow to perform all kinds of operations on a given file.
//Similarly U have static class Directory Class that contains APIs to create, Find, Remove and perform different operations on the given Folder
namespace Frameworks
{
    internal class Ex21FileIO
    {
        static string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SampleFile.csv");
        static void Main(string[] args)
        {
            // firstExampleForFileIO();
            //displayNamesAndAddresses();
            //displayAllDetails("C:/Phaniraj");
            //Get All PDF Documents from a given folder and display its details.
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //displayPdfDocDetails(folderPath);
            //Task: Get the PDF Docs and place them in a directory of UR Application. 
            copyPdfToMyFiles(folderPath);
        }

        private static void copyPdfToMyFiles(string folderPath)
        {
            string destinationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MyFiles");
            var files = Directory.GetFiles(folderPath, "*.pdf");
            Directory.CreateDirectory(destinationPath);
            foreach(var file in files)
            {
                var fs = new FileInfo(file);
                var newfile = File.Create(Path.Combine(destinationPath, fs.Name));
                newfile.Close();
                File.Copy(file, newfile.Name, true);
            }
        }

        private static void displayPdfDocDetails(string folderPath)
        {
            var entries = Directory.GetFiles(folderPath, "*.pdf");
            foreach(var entry in entries)
            {
                Console.WriteLine("FileName: " + entry);
                var time = File.GetCreationTime(entry);
                FileAttributes attributes = File.GetAttributes(entry);
                Console.WriteLine("File created time: " + time.ToString("dd/MM/yyyy"));
                var security = File.GetAccessControl(entry);
                var owner = security.GetOwner(typeof(System.Security.Principal.NTAccount));
                Console.WriteLine("Owner: " + owner.Value);
            }
        }

        private static void displayAllDetails(string path)
        {
            var entries = Directory.GetFileSystemEntries(path);
            foreach (var entry in entries)
            {
                FileAttributes attribute = File.GetAttributes(entry);
                if (attribute == FileAttributes.Directory)
                {
                    Console.WriteLine($"Directory Name: {entry}");
                    var tempList = Directory.GetFiles(entry);
                    foreach (var file in tempList)
                    {
                        Console.WriteLine(file);
                    }
                }
                else
                {
                    Console.WriteLine($"File Name: {entry}");
                }
            }
        }

        private static void displayNamesAndAddresses()
        {
            var records = getRecordsFromCSVFile();
            foreach (var rec in records)
                Console.WriteLine($"{rec.EmpName} from {rec.EmpAddress}");
        }

        private static void firstExampleForFileIO()
        {
            var fs = File.Create(fileName);
            fs.Close();
            File.WriteAllText(fileName, "Some content to the file");
            File.AppendAllText(fileName, "Some content is appended to the existing file");
            var content = File.ReadAllText(fileName);
            Console.WriteLine(content);
            var empDetails = createEmployee();
            File.AppendAllText("Data.csv", empDetails.ToString());
        }

        static List<Employee> getRecordsFromCSVFile()
        {
            List<Employee> records = new List<Employee>();
            //Read the contents of the CSV file and convert it into List<Employee>
            const string csvFile = "../../myData.csv";
            if(!File.Exists(csvFile))
            {
                Console.WriteLine("File Path is wrong!!!");
            }
            else
            {
                //Read all the contents of the file as lines
                var lines = File.ReadAllLines(csvFile);
                foreach(var line in lines)
                {
                    var words = line.Split(',');
                    var rec = new Employee();
                    rec.EmpId = Convert.ToInt32(words[0]);
                    rec.EmpName= words[1];
                    rec.EmpAddress = words[2];
                    rec.EmpSalary = Convert.ToInt32(words[3]); 
                    records.Add(rec);
                }
            }
            return records;
        }
        static Employee createEmployee()
        {
            //To do: Take inputs from the User and return a valid Employee object
            return null;
        }
    }
}
