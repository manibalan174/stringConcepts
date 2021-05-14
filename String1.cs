using System;

namespace StringPart1
{
    class Program
    {
            public  string masg2 = String.Empty;
            public  string masg3 = "";
            public   string str5 = null;
        public static void strMenthod(string FirstName, string LastName, string Location)
        {
            if(string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Location))
            {
                throw new Exception("Data Are Empty Please Fill information");
            }
            string Name = FirstName+" "+LastName;
            string Role = "It's Worked in \" SoftWare Devloper \" in this company.";
            string EmpInfo = string.Format("Empolyee Name : {0}\nEmpolyee Location : {1}\nEmployee Role : {2}",Name,Location,Role);
            Console.WriteLine(EmpInfo);
            string Product = @" "" TaxBandids "" \ "" Express Tax "" \ "" PayWow ""  ";   
             Console.WriteLine("Company Product : "+Product);
            // Console.WriteLine("Enter"+masg2);
             //Console.WriteLine("Enter"+masg3);
            // Console.WriteLine("Enter"+str5);
        }   
        static void Main(string[] args)
        {   Console.Write("Enetr Frist Name : ");
            string n = Console.ReadLine();
             Console.Write("Enetr Last Name : ");
            string C = Console.ReadLine();
            Console.Write("Enetr Location : ");
            string l = Console.ReadLine();
             strMenthod(n,C,l);
         }
    }
}
