using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileCopyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter destination file name");
            string destination = Console.ReadLine();
            Console.WriteLine("Enter Source file Name");
            string source = Console.ReadLine();
            try
            {
                // Directory.CreateDirectory("D://CAPGEMINI//DES");
                
                File.Copy("D://CAPGEMINI//" + source + ".txt", "D://CAPGEMINI//"+destination+".txt");//source->destination
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("File Not found");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally //read and display the contents of the file
            {
                FileStream fileStream = new FileStream("D://CAPGEMINI//" + destination + ".txt", FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                String data = streamReader.ReadToEnd();
                if (data.Length == 0)
                {
                    Console.WriteLine("Data transfer successful");
                    Console.WriteLine("No data available in the file - Its empty");
                }
                else
                {
                    Console.WriteLine("Data transfer successful");
                    Console.WriteLine("\nContent:\n" + data);
                }
                Console.ReadLine();

            }
            
        }
    }
}
