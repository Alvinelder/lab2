using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Person
    {
        public string FirstName, LastName;
        public int Age;
        public Person Spouse;

        public static Double SumofAllAges;
        public static int Count;

        // get full name age string
        public void GetFullnameage()
        { System.Console.WriteLine("First Name  ");
            this.FirstName = System.Console.ReadLine();
          System.Console.WriteLine("Last Name  ");
            this.LastName = System.Console.ReadLine();
          System.Console.WriteLine("Age    ");
            this.Age  = int.Parse(System.Console.ReadLine());
            Person.SumofAllAges += this.Age;
            Person.Count++;
        }
        ///////////////////////////////

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName + "   (" + this.Age + ")";
        }
        // print name and age string
        public void PrintNameandAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.Age);
            SumofAllAges += SumofAllAges + this.Age;
        }
        //////////////////
        public void GetMaritalstatus()
        {
            System.Console.Write("are you married? (y/n)   ");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.Spouse = new Person();
                this.Spouse.GetFullnameage();
                this.Spouse.Spouse = this;

            }
                }

    }
}
