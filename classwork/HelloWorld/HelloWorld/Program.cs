  /*
   * GRACE REED
   * ITSE 1430
   * LAB 1
  */
using System;

namespace HelloWorld
{
    //Pascal casing - Capatalize on word boundaries including the first word
    //Camel casing - Capatalize on word boundaries except first (e.g. firstName, payRate)
    class Program
    {
        //Function declaration - declaration to compiler that a function exists with a given signature
        //Function signature - function name and line parameter types (sometimes it will include return type)
        //Function definition - declaration + implementation
        static void Main(string[] args)
        {
            //A single line comment
            //Another line of comments

            //Display given string to outut
            //Arguments - data passed to function
            Console.WriteLine("Hello World!"); //printf, cout

            //Variable declaration:
            //T id;
            //int hours;
            //hours = 10; //Assignment operator: id = E

            //Indentifier Rules:
            // 1. Unique within scope
            // 2. Must start with underscore or letter
            // 3. Consist of letters, digits, and underscores
            //e.g.
            //  Valid? firstName, first_Name, first_name
            //  pay1Rate (Valid)
            //  1chance (Not valid)

            //Always camel case local variables
            //Preferred: T id = E;
            int hours = 10;

            //int pay = 0;
            //pay = hours * 9;
            int totalPay = hours * 9;

            //Function overloading - multiple functions with the same name but different parameters
            //atof, atoi
            Console.WriteLine(totalPay);
        }
    }
}
