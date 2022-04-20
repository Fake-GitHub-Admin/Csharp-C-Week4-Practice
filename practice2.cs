/*This file will do a classical simple parameter conditional scan and print list of all criminals and non criminals the next file will mess with arrays
and adding to appropiate list */

using System;
namespace MyApplication
{
    class CSProgress
    {
        static void theListFilter(String Name, String Gender, int age, String YesorNoCriminal)
            
             
            {
             if(YesorNoCriminal == "Y")
                    {
                Console.WriteLine("Suspect " + Name + " " + Gender + " " + "(age: " + age + ") tested Positive on test for Criminals");
                    }

              else if(YesorNoCriminal == "N")
                    {
                Console.WriteLine("Suspect " + Name + " " + Gender + " " + "(age:" + age + ") tested Negative on test for Criminals");
                    }
                else
                    {
                Console.WriteLine("Error, " + Name + " " + "Please Enter in Y or N");
                    }

            }

    static void Main(string[] args)
        {
            Console.WriteLine("This is in bulleted list format of everyone");
            theListFilter("Eberhault", "Male", 40, "Y");
            theListFilter("Sarah Lee", "Female", 40, "Y");             
            theListFilter("Rose Ana", "Female", 19, "N");
            theListFilter("John Blue", "Male", 27, "Y");
            theListFilter("Eberhault Wick", "Male", 40, "B");


            Console.WriteLine("C# Progress as of 4/20");


        }


        static void anotherrandomMethod()
        {

        }
    }
}
