using System;
using System.Text;

namespace Stringpart2
{
    class Program
    {

        public static void Builder()
        {
                 StringBuilder sb = new StringBuilder("C");
        	sb.Append(", C++");
        	sb.Append(", Java");
        	sb.AppendLine();
        	sb.Append("Welcome to Progaraming Language");
            Console.WriteLine(sb);
 
            StringBuilder sb1 = new StringBuilder("Welcome World");
        	sb1.Insert(8, "to My ");
            Console.WriteLine("Insert String: " + sb1);
 
    	    StringBuilder sb2 = new StringBuilder("Welcome to ");
        	sb2.Remove(8, 3);
            Console.WriteLine(sb2);
 
            StringBuilder sb3 = new StringBuilder("Welcome to Guys World");
        	sb3.Replace("Guys", "My");
            Console.WriteLine(sb3);
            Console.ReadLine();

        }
        public static void Builder1()
        {
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" Every One");
            sb.Insert(15," !");
            sb.AppendLine();
             sb.Append("Welcome to My World");
             sb.Append("This Name is Earth");
           //  sb.Remove(16,16);
            // sb.Clear();
            Console.WriteLine("First Append Valus: "+sb);
             Console.WriteLine("First Append Valus: "+sb.Length);

             StringBuilder sb1 = new StringBuilder(" hello This IS My Demo");
            
             sb.AppendLine();
             sb.Append("Say Hai");
              string cSb = string.Concat(sb,sb1);
             Console.WriteLine("Concate : {0}",cSb);
        }
        static void Main(string[] args)
        {
            Builder();
            Builder1();
        }
    }
}
