using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

}
    // EXAMPLE OF MAKING A PYRAMID OF NUMBERS USING FOR LOOPS 1 121 12321 1234321 VERTICALLY
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int intLayers = 9, intSpace, intNum, j;

//            for (j = 1;  j <= intLayers; j++) //always try to use variables in loops if possible like j in rest of program. NOT declare new variables. 
//                                                //Overall loop that tells how many rows/layers deep to go
//            {
//                for (intSpace = 1; intSpace <= (intLayers - j); intSpace++ ) // neat little trick to enter in spaces
//                {
//                    Console.Write(" ");
//                }
//                for (intNum = 1; intNum <= j; intNum++) //increasing #
//                {
//                    Console.Write(intNum);
//                }
//                for(intNum = (intNum-2); intNum >=1; intNum--) // decreasing #
//                {
//                    Console.Write(intNum);
//                }
//                Console.WriteLine(); 
//            }
//            Console.ReadLine();
//        }
//    }
//}

    /// <summary>
    /// EXAMPLE OF RAISING USER INPUT # TO THE THIRD POWER AND ASKING IF CONTINUE
    /// </summary>
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int intPower = 3, intInput;
//            string strGo;
//            bool bContinue = false;

//            while (bContinue == false) 
//            {
//                Console.Write("Please enter any number you want to see the third power of: ");
//                intInput = Int32.Parse(Console.ReadLine());
//                Console.WriteLine(Math.Pow(intInput, intPower));
//                Console.Write("Would you like to continue? Press either 'y' or 'Y' then enter: ");
//                strGo = Console.ReadLine();
//                if (strGo == "y")
//                {
//                    //Console.WriteLine("goodbye"); //have to put these y and Y at the top of if statements or else it won't work. Put != at bottom
//                    //bContinue = true;
//                    continue;
//                }
//                else if(strGo == "Y")
//                {
//                    //Console.WriteLine("goodbye");
//                    //bContinue = true;
//                }
//                else if (strGo !="y")
//                {
//                    Console.WriteLine("goodbye");
//                    bContinue = true;
//                    //continue;
//                }
//                else if (strGo != "Y")
//                {
//                    Console.WriteLine("goodbye");
//                    bContinue = true;
//                    //continue;
//                }

//            }

//            //Math.Pow(int,power);
//        }
//    }
//}

    /// <summary>
    /// EXAMPLE OF FOR NESTED FOR LOOPS WRITING 122333444455555 (BUT THEY SHOW VERTICALLY///
    /// </summary>
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        int i, j;

    //        for (i = 1; i <= 5; i++)
    //        {
    //            Console.WriteLine();
    //            for (j = 1; j <= i; j++)
    //            {
    //                Console.Write(i);
    //            }
    //        }
    //        Console.ReadLine();
    //    }

    //}
//}
    /// <summary>
    /// //EXAMPLE OF CREATING A TABLE OF MULTIPLICATION RESULTS FROM USER PROVIDED #
    /// </summary>
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int userNum, i, j = 4, res;

//            Console.Write("Please enter a number you would like to see multiplied by 1 - 100: ");
//            userNum = Int32.Parse(Console.ReadLine());

//            for (i = 1; i <= 100; i++) 
//            {
//                res = userNum * i;
//                Console.Write("{0} X {1} = {2}\t", userNum, i, res);
//                if (i == j)
//                {
//                    j = j + 4;
//                    Console.WriteLine();
//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine("Press enter to exit...");
//            Console.ReadLine();
//        }
//    }
//}



    /// <summary>
    /// ///EXAMPLE OF WHILE(TRUE) LOOP. INFINITE LOOP UNTIL USER ENTERS SPECIAL CHARACTER
    /// </summary>
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int num, sum = 0, res = 0;
//            Console.WriteLine("Enter number to add. Press -1 for Terminate the program");
//            while (true)
//            {
//                num = Convert.ToInt32(Console.ReadLine());
//                if (num == -1)
//                {
//                    break;
//                }
//                sum = res;
//                res += num;
//                Console.WriteLine("\n{0} + {1} = {2}", sum, num, res);
//            }
//            Console.WriteLine("\n\nAborting... Press Enter.");
//            Console.ReadLine();
//        }
//    }
//}


        /// <summary>
        /// ///////Example of a struct///////////////////////
        /// </summary>
//        struct Employee
//        {
//            public string eeName; //creating 3 different variables in single structure
//            public int eeSalary;
//            public int eeAge;
//        }

//        static void Main(string[] args)
//        {
//            Employee name1, name2; //creating 2 ee variables

//            Console.WriteLine("Please enter Employee 1 name:\t"); //asking user for information
//            name1.eeName = Console.ReadLine();
//            Console.WriteLine("Please enter Employee 1 salary:\t");
//            name1.eeSalary = Int32.Parse(Console.ReadLine());
//            Console.WriteLine("Please enter Employee 1 age:\t");
//            name1.eeAge = Int32.Parse(Console.ReadLine());

//            Console.WriteLine("Please enter Employee 2 name:\t"); //asking user for information
//            name2.eeName = Console.ReadLine();
//            Console.WriteLine("Please enter Employee 2 salary:\t");
//            name2.eeSalary = Int32.Parse(Console.ReadLine());
//            Console.WriteLine("Please enter Employee 2 age:\t");
//            name2.eeAge = Int32.Parse(Console.ReadLine());

//            //Displaying value of name1 variable
//            Console.Clear();
//            Console.WriteLine("Hit enter to see Employee information");
//            Console.ReadLine();
//            Console.Write("\n\n===================");
//            Console.Write("\n\t\tEmployee 1\n");
//            Console.Write("===================\n\n");

//            Console.WriteLine("Employee 1 Name:\t{0}", name1.eeName);
//            Console.WriteLine("\nEmployee 1 Salary:\t{0}", name1.eeSalary);
//            Console.WriteLine("\nEmployee 1 Age:\t{0}", name1.eeAge);
            
//            Console.WriteLine("Hit enter to see next Employee information");
//            Console.ReadLine();
//            Console.Clear();
//            Console.Write("\n\n===================");
//            Console.Write("\n\t\tEmployee 2\n");
//            Console.Write("===================\n\n");

//            Console.WriteLine("Employee 2 Name:\t{0}", name2.eeName);
//            Console.WriteLine("\nEmployee 2 Salary:\t{0}", name2.eeSalary);
//            Console.WriteLine("\nEmployee 2 Age:\t{0}", name2.eeAge);
//            Console.ReadLine();
//        }
//    }
//}


    /// <summary>
    /// ///////////Example of enumerators////////////////
    /// </summary>
//    public enum colorness
//    {
//        redFirstEnumerator,
//        yellowSecondEnumerator,
//        greenThirdEnumerator
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            colorness one = colorness.redFirstEnumerator;
//            colorness two = colorness.yellowSecondEnumerator;
//            colorness three = colorness.greenThirdEnumerator;
//            Console.WriteLine(one);
//            Console.ReadLine();
//            Console.WriteLine(two);
//            Console.ReadLine();
//            Console.WriteLine(three);
//            Console.ReadLine();

//        }

//    }
//}

    //////////// CALLING 2 CLASSES AND USING CONTINUE AND BREAK //////////
//        static void Main(string[] args)
//        {
//            int num = 1, result;

//            add a = new add();
//            subtract s = new subtract();

//            result = a.adding(num);
//            result = s.subtracting(result);
//            Console.WriteLine(result);
            
//            Console.ReadLine();

//            while (result != 15)
//            {
//                result = ++result;
//                Console.WriteLine("This is where result value is at:  " + result);
//                if (result == 13)
//                {
//                    Console.WriteLine("Thought you had a friend...GOODBYE!");
//                    Console.ReadLine();
//                    break;
//                }
//                Console.ReadLine();
//                continue;
//            }

//        }

//    }
//}

    /// <summary>
    /// CALCULATING PERCENTAGE VALUE FROM USER PROVIDED NUMBER
    /// </summary>
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        double result, num1;
    //        int intAnswer;

    //    label:

    //        Console.WriteLine("Please enter a number to calculate percentage value:  ");
    //        num1 = Int32.Parse(Console.ReadLine());
    //        num1 = num1 / 100;
    //        Console.WriteLine("Here is the percentage form:  " + num1);
    //        Console.WriteLine("Would you like to continue? 1 for yes or 2 for no");
    //        intAnswer = Int32.Parse(Console.ReadLine());
    //        if (intAnswer == 1)
    //        {
    //            goto label;
    //        }
    //        else if (intAnswer == 2)
    //        {
    //            Console.WriteLine("Thank you, come again");
    //        }




            ///// USING CLASS FROM ANOTHER PART IN PROJECT
            //int result;
            //int num1, num2;
            //Console.WriteLine("Enter first value to add:\t");
            //num1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second value:\t");
            //num2 = Int32.Parse(Console.ReadLine());

            //add a = new add();

            //result = a.adding(num1, num2);
            //Console.WriteLine(result);
            //Console.WriteLine("Press Enter to exit");
            //Console.ReadLine();
            //////
            
            //////GRABBING VALUES FROM USER AND DISPLAYING THEM IN CONSOLE
            ////cretaing integer type variable
            //int pin, houseNumber;
            //string name, city, street;
            ////Displaying message
            //Console.WriteLine("Please enter name:");
            //name = Console.ReadLine();

            //Console.WriteLine("Enter City:");
            //city = Console.ReadLine();

            //Console.WriteLine("Enter House #:");
            //houseNumber = Int32.Parse(Console.ReadLine()); //need to convert int to string

            //Console.WriteLine("Enter Street:");
            //street = Console.ReadLine();

            //Console.WriteLine("Enter PIN:");
            //pin = Int32.Parse(Console.ReadLine()); //need to convert int to string


            //Console.WriteLine("Name: {0} \t City: {1} \t House#: {2} \t Street: {3} \n PIN: {4} \n Press enter to exit", name, city, houseNumber, street, pin); //Output

            //Console.ReadLine();
            //////////////
//        }
//    }
//}
