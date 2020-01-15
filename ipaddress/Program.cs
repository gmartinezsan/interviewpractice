using System;

namespace ipaddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DefangIPaddr("255.100.50.0"));
        }

         public static string DefangIPaddr(string address) {
                if (address != String.Empty){
                    string output = "";
                    foreach(char a in address)
                    {
                        if (a == '.')
                        {
                           output += "[.]";
                        }
                        else
                        {
                           output += a;
                        }
                    }
               return output;
            }
            return String.Empty;
        }
    }
}
