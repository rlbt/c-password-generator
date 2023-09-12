using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__password_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Would you like to Generate a Randomised Password?");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Y");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("N");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");

            string ui = Console.ReadLine();
            string Loop = "";

            while (!(ui == "Y" || ui == "y" || ui == "N" || ui == "n"))
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Input a valid answer.");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                ui = Console.ReadLine();
            }
            if (ui == "Y" || ui == "y")
            {

                string PasswordChoice = "0987654321!$%^&()-_=+abcdefghijkmnlopqrstuvwxyz1234567890ABCDEFGHIKMNLOPQRSTUVWXYZ!$%^&()-_=+1234567890abcdefghijkmnlopqrstuvwxyzABCEFGHIJKMNLOPQRSTUVWXYZ1234567890!$%^&()-_=+";

                Random numgen = new Random();

                int num = numgen.Next(0, PasswordChoice.Length);
                int num2 = numgen.Next(0, PasswordChoice.Length);
                int num3 = numgen.Next(0, PasswordChoice.Length);
                int num4 = numgen.Next(0, PasswordChoice.Length);
                int num5 = numgen.Next(0, PasswordChoice.Length);
                int num6 = numgen.Next(0, PasswordChoice.Length);
                int num7 = numgen.Next(0, PasswordChoice.Length);
                int num8 = numgen.Next(0, PasswordChoice.Length);
                int num9 = numgen.Next(0, PasswordChoice.Length);
                int num10 = numgen.Next(0, PasswordChoice.Length);
                int num11 = numgen.Next(0, PasswordChoice.Length);
                int num12 = numgen.Next(0, PasswordChoice.Length);


                var Char1 = PasswordChoice[num];
                var Char2 = PasswordChoice[num2];
                var Char3 = PasswordChoice[num3];
                var Char4 = PasswordChoice[num4];
                var Char5 = PasswordChoice[num5];
                var Char6 = PasswordChoice[num6];
                var Char7 = PasswordChoice[num7];
                var Char8 = PasswordChoice[num8];
                var Char9 = PasswordChoice[num9];
                var Char10 = PasswordChoice[num10];
                var Char11 = PasswordChoice[num11];
                var Char12 = PasswordChoice[num12];


                string GenPass = Char1 + "" + Char2 + "" + Char3 + "" + Char4 + "" + Char5 + "" + Char6 + "" + Char7 + "" + Char8 + "" + Char9 + "" + Char10 + "" +
                                     Char11 + "" + Char12;

                Console.WriteLine("");
                Console.WriteLine("Generated Password: " + GenPass);
                Console.Write("Would you like to Generate a ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("New Password");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("?");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Y");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("N");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("");

                Loop = Console.ReadLine();
            }

            else if (Loop == "N" || Loop == "n")

            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You will be taken back to the menu then");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");

            }

            while (!(Loop == "Y" || Loop == "y" || Loop == "N" || Loop == "n"))
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Input a valid answer.");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Loop = Console.ReadLine();
            }

            while (Loop == "Y" || Loop == "y")
            {

                string PasswordChoice = "0987654321!$%^&()-_=+abcdefghijkmnlopqrstuvwxyz1234567890ABCDEFGHIKMNLOPQRSTUVWXYZ!$%^&()-_=+1234567890abcdefghijkmnlopqrstuvwxyzABCEFGHIJKMNLOPQRSTUVWXYZ1234567890!$%^&()-_=+";

                Random numgen = new Random();

                int num = numgen.Next(0, PasswordChoice.Length);
                int num2 = numgen.Next(0, PasswordChoice.Length);
                int num3 = numgen.Next(0, PasswordChoice.Length);
                int num4 = numgen.Next(0, PasswordChoice.Length);
                int num5 = numgen.Next(0, PasswordChoice.Length);
                int num6 = numgen.Next(0, PasswordChoice.Length);
                int num7 = numgen.Next(0, PasswordChoice.Length);
                int num8 = numgen.Next(0, PasswordChoice.Length);
                int num9 = numgen.Next(0, PasswordChoice.Length);
                int num10 = numgen.Next(0, PasswordChoice.Length);
                int num11 = numgen.Next(0, PasswordChoice.Length);
                int num12 = numgen.Next(0, PasswordChoice.Length);

                var Char1 = PasswordChoice[num];
                var Char2 = PasswordChoice[num2];
                var Char3 = PasswordChoice[num3];
                var Char4 = PasswordChoice[num4];
                var Char5 = PasswordChoice[num5];
                var Char6 = PasswordChoice[num6];
                var Char7 = PasswordChoice[num7];
                var Char8 = PasswordChoice[num8];
                var Char9 = PasswordChoice[num9];
                var Char10 = PasswordChoice[num10];
                var Char11 = PasswordChoice[num11];
                var Char12 = PasswordChoice[num12];


                string GenPass = Char1 + "" + Char2 + "" + Char3 + "" + Char4 + "" + Char5 + "" + Char6 + "" + Char7 + "" + Char8 + "" + Char9 + "" + Char10 + "" + Char11 + "" + Char12;

                Console.WriteLine("");
                Console.WriteLine("Generated Password: " + GenPass);
                Console.Write("Would you like to Generate a ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("New Password");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("?");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Y");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("N");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("");

                Loop = Console.ReadLine();

                while (!(Loop == "Y" || Loop == "y" || Loop == "N" || Loop == "n"))
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Input a valid answer.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Loop = Console.ReadLine();

                }

                if (Loop == "N" || Loop == "n")
                {

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You will be taken back to the menu.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    return;
                }
            }
        
        }
    }
}
