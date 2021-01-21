using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace participantslib
{
    public class Participant
    {
        public int EmpId;
        public string Name;
        static string CompanyName;
        public double FoundationMarks;
        public double WebBasicMarks;
        public double DotNetMarks;
        static int TotalMarks ;
        public double ObtainedMarks;
        public double Percentage;

        
        public Participant()
        {

        }

        public Participant(int EmpId,string Name , double FoundationMarks, double WebBasicMarks, double DotNetMarks)
        {
            this.EmpId = EmpId;
            this.Name = Name;
            this.FoundationMarks = FoundationMarks;
            this.WebBasicMarks = WebBasicMarks;
            this.DotNetMarks = DotNetMarks;
        }

       static Participant()
        {
            Participant.TotalMarks = 300;
            Participant.CompanyName = "Corporate University";

        }

        public void CalculateTotalMarks()
        {
            ObtainedMarks = FoundationMarks+ WebBasicMarks+ DotNetMarks;
        }

        public void CalculatePercentage(double n)
        {
            Console.WriteLine("The total is:" + n);
            Percentage = (n/3);
        }

        public void DisplayPercentage(double num)
        {
            Console.WriteLine("The percentage is:" + num+"%");
            Console.ReadKey();
         }
    }
}
