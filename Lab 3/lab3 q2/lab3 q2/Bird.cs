using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_q2
{
   //check if the bird can fly st this height
    public class Bird
    {
        public string Name;
        public double Maxheight;
        public Bird() //Default Constructor
        {
            this.Name = "Crow";
            this.Maxheight = 500; // maximum height till which the birdy can fly
            //
            // TODO: Add constructor logic here
            //
        }
        public Bird(string birdname, double max_ht) //Overloaded Constructor
        {
            this.Name = birdname;
            this.Maxheight = max_ht;
        }
        public void fly()
        {
            Console.WriteLine(this.Name+" is flying at max altitude "+this.Maxheight);
        }
        public void fly(double AtHeight)
        {
            if (AtHeight <= this.Maxheight)
                Console.WriteLine(this.Name + " flying at " + AtHeight.ToString());
            else
        Console.WriteLine(this.Name +" cannot fly at " +this.Maxheight);
            Console.ReadLine();
        }
    }
}
