using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class program
    {

    }
}
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
