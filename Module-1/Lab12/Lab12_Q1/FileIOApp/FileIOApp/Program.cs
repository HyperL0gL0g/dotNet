using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIOApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name  to create");
            string fileName = Console.ReadLine();

            FileStream fileStream=null;
            StreamReader streamReader=null;
            try
            {
               // Directory.CreateDirectory("D://CAPGEMINI");
                fileStream = new FileStream("D://CAPGEMINI//" + fileName + ".txt", FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
                streamReader = new StreamReader(fileStream);
                String data = streamReader.ReadToEnd();
                Console.WriteLine("\nContent:\n" + data);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();
                if (fileStream != null)
                    fileStream.Close();

                Console.ReadLine();
            }
            
                      
        }
    }
}
