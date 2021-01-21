using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace delegatiVezbNet
{
    class Program
    {
        delegate void Print(string parametar);
        static public DateTime time;

        //=================================================================================
        static void LogIn(string name)
        {
            time = DateTime.Now;
            WriteLine(name + " is log in " + time + Environment.NewLine);
        }
        //----------------------------------------------------------------
        static void LogOut(string name)
        {
            time = DateTime.Now;
            WriteLine(name + " is log out " + time + Environment.NewLine);
        }
        //=================================================================================

        static void Main(string[] args)
        {
            Print guest1, guest2, guest3, guest4;
            string line = new String('-', 20);//ISPIS 20 CRTICA....

            guest1 = new Print(LogIn);
            guest2 = new Print(LogOut);
            guest3 = guest1 + guest2;
            guest4 = guest3 - guest1;

            WriteLine(line + Environment.NewLine);//----------------

            //=================================================================================
            WriteLine("Marko is going to log in! " + Environment.NewLine);
            guest1("Marko");
            WriteLine(line);

            WriteLine("Stefan is going to log out! " + Environment.NewLine);
            guest2("Stefan");
            WriteLine(line);

            WriteLine("Vukasin is going to log in  and log out! " + Environment.NewLine);
            guest3("Vukasin");
            WriteLine(line);

            WriteLine("David is going to log in  and log out!  But we need only time when loged out!" + Environment.NewLine);
            guest4("David");
            WriteLine(line);
            //=================================================================================

            Console.ReadKey();
        }
    }
}
