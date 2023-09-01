using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace Encoder
{
    class Program
    {
        public static string Encoding(char chr)
        {
            switch (chr)
            {
                case ' ':
                    return ("  ");
                case 'a':
                    return " .- ";
                case 'b':
                    return " -... ";
                case 'c':
                    return " -.-. ";
                case 'd':
                    return " -.. ";
                case 'e':
                    return " . ";
                case 'f':
                    return " ..-. ";
                case 'g':
                    return " --. ";
                case 'h':
                    return " .... ";
                case 'i':
                    return " .. ";
                case 'j':
                    return " .--- ";
                case 'k':
                    return " -.- ";
                case 'l':
                    return " .-.. ";
                case 'm':
                    return " -- ";
                case 'n':
                    return " -. ";
                case 'o':
                    return " --- ";
                case 'p':
                    return " .--. ";
                case 'q':
                    return " --.- ";
                case 'r':
                    return " .-. ";
                case 's':
                    return " ... ";
                case 't':
                    return " - ";
                case 'u':
                    return " ..- ";
                case 'v':
                    return " ...- ";
                case 'w':
                    return " .-- ";
                case 'x':
                    return " -..- ";
                case 'y':
                    return " -.-- ";
                case 'z':
                    return " --.. ";
                case '0':
                    return " ----- ";
                case '1':
                    return " .----";
                case '2':
                    return " ..--- ";
                case '3':
                    return " ...-- ";
                case '4':
                    return " ....- ";
                case '5':
                    return " ..... ";
                case '6':
                    return " -.... ";
                case '7':
                    return " --... ";
                case '8':
                    return " ---.. ";
                case '9':
                    return " ----. ";
                default:
                    return "error encountered";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to encode");

            string str = Console.ReadLine();

            if (!Regex.IsMatch(str, @"^[a-zA-Z0-9\s]*$"))
            {
                Console.WriteLine("Cannot convert to morse");
            }

            str = str.ToLower();

            string encodedStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                encodedStr += Encoding(str[i]);
            }

            Console.WriteLine(encodedStr);

        }
    }
}

