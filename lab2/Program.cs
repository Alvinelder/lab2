namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter info for P1 ");
            System.Console.WriteLine(" ");


            Person P1 = new Person();
            P1.GetFullnameage();
            P1.GetMaritalstatus();
            P1.Spouse.GetFullName();

            System.Console.WriteLine(" ");
            System.Console.WriteLine(" Enter info for P2 ");
            System.Console.WriteLine(" ");
                        
            Person P2 = new Person();
            P2.GetFullnameage();
            P2.GetMaritalstatus();
            P1.Spouse.GetFullName();
            /////////////
            System.Console.WriteLine();
            System.Console.WriteLine(" Printing Results");
            System.Console.WriteLine(P1.GetFullName());
            System.Console.WriteLine(P1.Spouse.GetFullName());
            System.Console.WriteLine(P2.GetFullName());
            System.Console.WriteLine(P2.Spouse.GetFullName());

            System.Console.WriteLine("Average Age is " + (Person.SumofAllAges / Person.Count));
            System.Console.ReadKey();

        }
    }
}
