using System;
namespace MyApplication
{
    class CSProgress
    {
        static void theListFilter(String Name, String Gender, int age, String YesorNoCriminal)          
            {
                List<String> ViolatorsList = new List<String>();
                List<String> NonViolatorsList = new List<String>();
                List<String> ErrorList = new List<String>();
                

            //All Console.WriteLine have now been commented to see whether the function under the class is doing what is supposed to do.
            if (YesorNoCriminal == "Y")
                    {
                     ViolatorsList.Add(Name); 
                //Console.WriteLine("Suspect " + Name + " " + Gender + " " + "(age: " + age + ") tested Positive on test for Criminals");
                    }

              else if(YesorNoCriminal == "N")
                    {
                    NonViolatorsList.Add(Name);
                //Console.WriteLine("Suspect " + Name + " " + Gender + " " + "(age:" + age + ") tested Negative on test for Criminals");
                    }
                else
                    {
                ErrorList.Add(Name);
                //Console.WriteLine("Error, " + Name + " " + "Please Enter in Y or N");
                    }
            //This for loop i
            /*
             This is in bulleted list format of everyone
             Violators include: Eberhault
             Violators include: Sarah Lee
             Non-Violators include: Rose Ana
             Violators include: John Blue
             */

            /*
            foreach (String i in ViolatorsList)
            {
                Console.WriteLine("Violators include: " + i);
            }
            foreach (String i in NonViolatorsList)
            {
                Console.WriteLine("Non-Violators include: " + i);
            }
            */


            Console.WriteLine(ViolatorsList);
            Console.WriteLine(NonViolatorsList);
            Console.WriteLine(ErrorList);
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

    }//No Code outside of the class unless it going to be another class 
    
}
