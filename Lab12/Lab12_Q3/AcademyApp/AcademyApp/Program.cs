using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            char cont;
            do
            {
                Console.WriteLine("Choose\n0) Exit\n1) Create branch Directories\n2) Write in Branch File\n3) Create a backup copy\n4) View the details of the branch files");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                      
                        createBranchDir();
                        break;
                    case 2:
                        Console.WriteLine("Enter the branch name where u want to write");
                        string s = Console.ReadLine();
                        Console.WriteLine("Please Proceed and write in " + s + " branch file");
                        string data = Console.ReadLine();
                        writeInBranch(s,data);
                        break;
                    case 3:
                        createBackUp();
                        break;
                    case 4:
                        Console.WriteLine("Enter the file name which you want to view");
                        String name = Console.ReadLine();
                        viewDetails(name);
                        break;
                    default:
                        Console.WriteLine("Please Enter proper Option");
                        break;
                }
                Console.WriteLine("Continue?y/n");
                cont = Convert.ToChar(Console.ReadLine());
            } while (cont=='y');
        }

        private static void createBranchDir()
        {
            try
            {
                Directory.CreateDirectory(@"D:/CAPGEMINI/Academy");
                Directory.CreateDirectory(@"D:/CAPGEMINI/Academy/Chennai");
                File.Create(@"D:/CAPGEMINI/Academy/Chennai/Chennai.txt").Dispose();

                Directory.CreateDirectory(@"D:/CAPGEMINI/Academy/Banglore");
                File.Create(@"D:/CAPGEMINI/Academy/Banglore/Banglore.txt").Dispose();

                DirectoryInfo directoryInfo = new DirectoryInfo(@"D:/CAPGEMINI/Academy/Mumbai");
                directoryInfo.Create();
                FileInfo fileInfo = new FileInfo(@"D:/CAPGEMINI/Academy/Mumbai/Mumbai.txt");
                fileInfo.Create().Dispose();

                directoryInfo = new DirectoryInfo(@"D:/CAPGEMINI/Academy/Pune");
                directoryInfo.Create();
                fileInfo = new FileInfo(@"D:/CAPGEMINI/Academy/Pune/Pune.txt");
                fileInfo.Create().Dispose();
               
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void writeInBranch(string branch,string data)
        {
            try
            {
                FileStream fileStream = new FileStream("D://CAPGEMINI//Academy//" + branch + "//" + branch + ".txt",FileMode.Open,FileAccess.ReadWrite,FileShare.Read);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(data);
                streamWriter.Flush();
                streamWriter.Close();
                fileStream.Close();
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void createBackUp()
        {
            try
            {
                Directory.CreateDirectory("C://Users//KIIT//Desktop//CAP//Academy");
                Directory.CreateDirectory("C://Users//KIIT//Desktop//CAP//Academy//Chennai");
                Directory.CreateDirectory("C://Users//KIIT//Desktop//CAP//Academy//Banglore");
                DirectoryInfo directoryInfo = new DirectoryInfo("C://Users//KIIT//Desktop//CAP//Academy//Mumbai");
                directoryInfo.Create();
                directoryInfo = new DirectoryInfo("C://Users//KIIT//Desktop//CAP//Academy//Pune");
                directoryInfo.Create();
                File.Copy(@"D:/DemoFolder/Academy/Chennai/Chennai.txt", "C://Users//KIIT//Desktop//CAP//Academy//Chennai/ChennaiCopy.txt");
                File.Copy(@"D:/DemoFolder/Academy/Banglore/Banglore.txt", "C://Users//KIIT//Desktop//CAP//Academy//Banglore//BangloreCpoy.txt");
                File.Copy(@"D:/DemoFolder/Academy/Mumbai/Mumbai.txt", "C://Users//KIIT//Desktop//CAP//Academy//Mumbai//MumbaiCopy.txt");
                File.Copy(@"D:/DemoFolder/Academy/Pune/Pune.txt", "C://Users//KIIT//Desktop//CAP//Academy//Pune//PuneCopy.txt");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        private static void viewDetails(String fileName)
        {
            try
            {
                FileStream fileStream = new FileStream("D://CAPGEMINI//Academy//" + fileName + "//" + fileName + ".txt", FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                string data = streamReader.ReadToEnd();
                Console.WriteLine("*****************${fileName}*********************");
                Console.WriteLine(data);
                streamReader.Close();
                fileStream.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
