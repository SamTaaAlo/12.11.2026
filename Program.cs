using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Aufgabe4();
        }

        static void Aufgabe3()
        {
            string input;
            string note;
            bool wiederholen = true;
            int punkte = 0;


            while ( wiederholen ) {
                Console.Write("Gib deine Punktzahl ein: ");
                input = get_input();

                if ( is_string_INTable(input))
                {
                    punkte = int.Parse(input);
                    wiederholen = false;
                }
                else
                {
                    Console.WriteLine("ungültige eingabe");
                    Console.Write("wollen sie nochmal versuchen? Y/N: ");
                    input = get_input();

                    if ( input == "y" || input == "Y") continue;

                    else return;
                }
            }

            if ( punkte >= 90 ) note = "Sehr Gut.";
            else if ( punkte >= 75 ) note = "Gut.";
            else if ( punkte >= 50 ) note = "Befriedigend.";
            else note = "Durchfegfallen.";

            Console.WriteLine("Note: " + note);
        }

        static void Aufgabe4()
        {
            double num1 = 0;
            double num2 = 0;
            char op = '0';
            string input;
            bool wiederholen = true;

            while ( wiederholen )
            {
                Console.Write("Gib die erste Zahl ein: ");
                input = get_input();

                if ( is_string_doubleable(input))
                {
                    num1 = double.Parse(input);
                    wiederholen = false;
                }
                else
                {
                    Console.WriteLine("ungültige eingabe");
                    Console.Write("wollen sie nochmal versuchen? Y/N: ");
                    input = get_input();

                    if ( input == "y" || input == "Y") continue;

                    else return;
                }
            }

            wiederholen = true;

            while ( wiederholen )
            {
                Console.Write("Gib den operator ein: ");
                input = get_input();

                if ( input[0] == '+' || input[0] == '-' || input[0] == '*' || input[0] == '/')
                {
                    op = input[0];
                    wiederholen = false;
                }
                else
                {
                    Console.WriteLine("ungültige eingabe");
                    Console.Write("wollen sie nochmal versuchen? Y/N: ");
                    input = get_input();

                    if ( input == "y" || input == "Y") continue;

                    else return;
                }
            }

            wiederholen = true;

            while ( wiederholen )
            {
                Console.Write("Gib die erste Zahl ein: ");
                input = get_input();

                if ( is_string_doubleable(input))
                {
                    num2 = double.Parse(input);
                    wiederholen = false;
                }
                else
                {
                    Console.WriteLine("ungültige eingabe");
                    Console.Write("wollen sie nochmal versuchen? Y/N: ");
                    input = get_input();

                    if ( input == "y" || input == "Y") continue;

                    else return;
                }
            }

            if ( op == '+' ) Console.WriteLine(num1 + " " + op + " " + num2 + " = " + (num1 + num2));
            else if ( op == '-' ) Console.WriteLine(num1 + " " + op + " " + num2 + " = " + (num1 - num2));
            else if ( op == '*' ) Console.WriteLine(num1 + " " + op + " " + num2 + " = " + (num1 * num2));
            else Console.WriteLine(num1 + " " + op + " " + num2 + " = " + (num1 / num2));
        }


        static string get_input()
        {
            string? input = Console.ReadLine();
            
            if ( input == null) return "";
            return input;
        }

        static bool is_string_doubleable(string input)
        {
            double x;

            if ( double.TryParse( input, out x) )
            {
                return true;
            }

            return false;
        }
        static bool is_string_INTable(string input)
        {
            int x;

            if ( int.TryParse( input, out x) )
            {
                return true;
            }

            return false;
        }    


    }

    
}