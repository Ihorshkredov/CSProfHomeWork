using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.IO;

namespace ReadFromXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPass = @"C:\Users\igors\source\repos\CSProfHomeWork\bin\Debug\net6.0\homework.xml";

            XDocument doc = XDocument.Load(folderPass);

            XElement root = doc.Root;

            var request = root.Descendants("Result").Where(element =>
                          element.Attribute("Message").Value != "No roots for this case");

            foreach ( var element in request )  
            {
                Console.WriteLine(new string('_',50));
                Console.WriteLine($" {element.FirstAttribute}");
                Console.WriteLine($"Roots are: X1 = {element.FirstNode},  X2 ={element.LastNode}");
                Console.WriteLine(new string('_',50));
            }
            Console.ReadLine();
        }
    }
}