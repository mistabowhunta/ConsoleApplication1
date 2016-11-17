using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            FileStream fsSource = new FileStream("C:\\Users\\inason\\Desktop\\Coding\\C#\\myFirstC#File.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fsSource)) //using streamreader class to read the file
            {
                data = sr.ReadToEnd();
            }
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
    //EXAMPLE OF FILE HANDLING OPENING (OR CREATING) TEXT FILE AND WRITING DATA IN IT.
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            FileStream fs = new FileStream("C:\\Users\\inason\\Desktop\\Coding\\C#\\myFirstC#File.txt", FileMode.Append);
//            byte[] bdata = Encoding.Default.GetBytes("Hello File Handling!");     // encoding a string into bytes then storing in array    
//            fs.Write(bdata, 0, bdata.Length); // tells how to write data: from what variable (in this case an array), starting from what index offset, how many elements in array
//            fs.Close();
//            Console.WriteLine("Successfully saved file with data : Hello File Handling!");
//            Console.ReadKey();
//        }
//    }
//}
/// <summary> 
/// EXAMPLE OF CONSTRUCTOR OVERLOADING AND USE OF DESTRUCTOR
/// </summary>
//    class ConstructorFun
//    {
//        public ConstructorFun()
//        {
//            Console.WriteLine("Hello I am the default constructor");
//        }
//        public ConstructorFun(string message)
//        {
//            Console.WriteLine(message);
//        }
//        public ConstructorFun(int intNum1, int intNum2)
//        {
//            int result;
//            result = intNum1 + intNum2;
//            Console.WriteLine("Adding {0} + {1} = {2}", intNum1, intNum2, result);
//        }
//        ~ConstructorFun()
//        {
//            Console.WriteLine("This is the destructor clearing memory");
//            Console.ReadLine();
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ConstructorFun CF = new ConstructorFun();
//            ConstructorFun CF2 = new ConstructorFun("Hello I am the overloaded constructor");
//            ConstructorFun CF3 = new ConstructorFun(50, 5);
//            Console.ReadLine();
//        }
//    }
//}
/// <summary>
/// EXAMPLE OF USING SYSTEM ERROR EXCEPTION INDEXOUTOFRANGE WHEN FOR LOOP GOES BEYOND ARRAY AMOUNT
/// </summary>
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] list = new string[5];
//            list[0] = "Sunday";
//            list[1] = "Monday";
//            list[2] = "Tuesday";
//            list[3] = "Wednesday";
//            list[4] = "Thursday";

//            try
//            {
//                for (int i = 0; i <= 5; i++)
//                {
//                    Console.WriteLine(list[i].ToString());
//                    Console.ReadLine();
//                }

//            }

//            catch(IndexOutOfRangeException ieo)
//            {
//                Console.WriteLine(ieo.Message);
//            }
//            Console.ReadLine();

//        }
//    }
//}
/// <summary>
/// EXAMPLE OF USING SYSTEM EXCEPTION NULLREFERENCEEXCEPTION TRY CATCH
/// </summary>
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string text = null;
//            try
//            {
//                int length = text.Length;
//                Console.WriteLine(length);
//                Console.ReadLine();
//            }
//            catch (NullReferenceException nex)
//            {
//                Console.WriteLine(nex.Message);
//            }
//            Console.ReadLine();
//        }
//    }
//}
/// <summary>
/// EXAMPLE OF USER STORING STRINGS INTO MULTI-DIMENSIONAL ARRAY, THEN COPYING THAT ARRAY AND DISPLAYING IT
/// </summary>
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i, j;
//            string[,] Objects = new string[3, 3]; //this array has 3 rows and each row contains three columns. ALWAYS remember comma to declare multi-dimensial array.
//            string[,] ObjectsTwo = new string[3, 3]; //making second array to copy first one from
//            for (i=0; i< 3; i++) //each row can be accessed using outer loop and each column of rows can be accessed using nested loop inside the outer loop
//            {
//                for (j=0; j<3; j++)
//                {
//                    Console.Write("Please enter 9 objects ANY objects you can think of: ");
//                    Objects[i, j] = Console.ReadLine();
//                }
//            }
//            Console.WriteLine("Press enter to see all the objects you entered. These objects were stored into an array then accessed again by pressing enter...");
//            Console.ReadLine();
//            for (i=0;i<3; i++)
//            {
//                for (j=0; j<3; j++)
//                {
//                    Console.WriteLine("=========================");
//                    Console.WriteLine(Objects[i, j]);
//                    Console.WriteLine("=========================");
//                }
//            }
//            Console.ReadLine();
//            Array.Copy(Objects, ObjectsTwo, 6); //the last number here specifies how many indexes is copied over.
//            Console.WriteLine("Here is copying first array and putting elements into second array: ");
//            for (i = 0; i < 3; i++)
//            {
//                for (j = 0; j < 3; j++)
//                {

//                    Console.WriteLine(ObjectsTwo[i, j]);

//                }
//            }
//            Console.ReadLine();
//        }
//    }
//}
/// <summary>
/// EXAMPLE OF STORING USER ENTERED VAIRABLES INTO AN ARRAY THAN DISPLAYING DATA
/// </summary>
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i;
//            int[] arr = new int[5];
//            for (i = 0; i <= 4; i++)
//            {

//                Console.Write("Please enter " + i + " out of 5 numbers that will be numerically sorted: ");
//                arr[i] = Int32.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("Here are your numbers in numerical order:");
//            Array.Sort(arr);
//            foreach (int j in arr)
//            {
//                Console.WriteLine(j);
//            }
//            Console.ReadLine();
//        }
//    }
//}
/// <summary>
/// EXAMPLE OF SENDING 2 VARIABLES AND RETURNING 4 VARIABLES USING OUT
/// </summary>
//    class Program
//    {
//        static void intInput(int number1, int number2, out int added, out int subtracted, out int multiplied, out float divised)
//        {
//            added = number1 + number2;
//            subtracted = number1 - number2;
//            multiplied = number1 * number2;
//            divised = (float)number1 / number2; //don't forget the float here

//        }
//        static void Main(string[] args)
//        {
//            int number1, number2, added, subtracted, multiplied;
//            float divised;
//            Console.Write("Please enter first number: ");
//            number1 = Int32.Parse(Console.ReadLine());
//            Console.Write("Please enter second number: ");
//            number2 = Int32.Parse(Console.ReadLine());

//            Program.intInput(number1, number2, out added, out subtracted, out multiplied, out divised);
//            Console.WriteLine("\n\n{0} + {1} = {2}", number1, number2, added);
//            Console.WriteLine("{0} - {1} = {2}", number1, number2, subtracted);
//            Console.WriteLine("{0} * {1} = {2}", number1, number2, multiplied);
//            Console.WriteLine("{0} / {1} = {2}", number1, number2, divised);

//            Console.ReadLine();
//        }

//    }



//}
/// <summary>
/// EXAMPLE OF PASSING BY REFERENCE AND VALUE
/// </summary>
//    class Program
//    {
//        public int addClass(int intNumber2)
//        {
//            intNumber2 = intNumber2 * 2;
//            return (intNumber2);
//        }
//        static int Calculate(ref int intNumber)
//        {
//            intNumber = intNumber + 20;
//            return (intNumber);
//        }
//        static void Main(string[] args)
//        {
//            int intPassingVariable = 50;
//            Console.WriteLine("Variable before referencing: " + intPassingVariable);
//            Program.Calculate(ref intPassingVariable); // not assigning variable here, simply pointing to the end result and the variable is 
//                                                       //changed after this line, but original variable remains unchanged
//            Console.WriteLine("Result after referencing: " + intPassingVariable);
//            Program prg = new Program();
//            intPassingVariable =  prg.addClass(intPassingVariable);
//            Console.WriteLine("Oh but wait, this is a variable being passed by value. The variable changed: " + intPassingVariable);
//            Console.ReadLine();
//        }
//    }
//}

/// <summary>
/// EXAMPLE OF PASSING VALUE VIA REFERENCE
/// </summary>
//    class Program
//    {

//        static int Calculate(ref int intNumber)
//        {
//            intNumber = intNumber + 20;
//            return (intNumber);
//        }
//        static void Main(string[] args)
//        {
//            int intPassingVariable = 50;
//            Console.WriteLine("Variable before referencing: " + intPassingVariable);
//            Program.Calculate(ref intPassingVariable); // not assigning variable here, simply pointing to the end result and the variable is 
//                                                        //changed after this line, but original variable remains unchanged
//            Console.WriteLine("Result after referencing: " + intPassingVariable);
//            Console.ReadLine();
//        }
//    }
//}
/// <summary>
/// EXAMPLE OF PARAMETER BEING PASSED TO METHOD THAN RETURNING
/// </summary>
//    class Program
//    {
//        int intNum = 5, intResult;
//        public int calculate(int Num) // returns integer value b/c declared method int
//        {

//            intNum = intNum + 5;
//            return (intNum);
//        }

//        static void Main(string[] args)
//        {
//            Program prg = new Program();
//            prg.intResult = prg.calculate(5);
//            Console.WriteLine("Result: " + prg.intResult);
//            Console.ReadLine();
//        }


//    }
//}
/// <summary>
/// EXAMPLE OF CALLING MULTIPLE METHODS LOCATED IN A DIFFERENT CLASS
/// </summary>
//    class Calculate
//    {
//        public int intNum1, intNum2, intResult;
//        public string chOps;

//        public void add()
//        {
//            intResult = intNum1 + intNum2;
//        }
//        public void Subtract()
//        {
//            intResult = intNum1 - intNum2;
//        }
//        public void Multiply()
//        {
//            intResult = intNum1 * intNum2;
//        }
//        public void Divide()
//        {
//            intResult = intNum1 / intNum2;
//        }
//        public void print()
//        {
//            Console.WriteLine();
//            Console.WriteLine("Result: " + intResult);
//            Console.WriteLine();
//            Console.WriteLine("Press Enter to exit...");
//            Console.ReadLine();
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculate cal = new Calculate();
//            Console.Write("Enter first number: ");
//            cal.intNum1 = Int32.Parse(Console.ReadLine());
//            Console.Write("Enter second number: ");
//            cal.intNum2 = Int32.Parse(Console.ReadLine());
//            Console.Write("What calculation would you like to perform on these two numbers? '+' '-' '*' '/': ");
//            cal.chOps = Console.ReadLine();

//            if (cal.chOps == "+")
//            {
//                cal.add();
//                cal.print();
//            }
//            else if (cal.chOps == "-")
//            {
//                cal.Subtract();
//                cal.print();
//            }
//            else if (cal.chOps == "*")
//            {
//                cal.Multiply();
//                cal.print();
//            }
//            else if (cal.chOps == "/")
//            {
//                cal.Divide();
//                cal.print();
//            }
//            else
//            {
//                Console.WriteLine("You did not enter the correct operator I told you too! Goodbye!");
//                Console.ReadLine();
//            }



//        }
//    }
//}
/// <summary>
/// EXAMPLE OF CALLING A STATIC CLASS BY ONLY WRITING CLASSNAME.METHODNAME(). WITHOUT CREATING AN OBJECT
/// </summary>
//    class Calculate
//    {
//        public static void add()
//        {
//            int intNum, intNum2, intResult;
//            Console.Write("Enter first # to be added: ");
//            intNum = Int32.Parse(Console.ReadLine());
//            Console.Write("Enter second # to be added: ");
//            intNum2 = Int32.Parse(Console.ReadLine());
//            intResult = intNum + intNum2;
//            Console.Write("\tResult: {0}", intResult);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculate.add();// becuase add class is static I can access it by writing only classname.methodname(). If it wasn't a static class I would need to create an object.
//                            //                                // Example of object if the class was not static: Variable var = new Variable();
//            Console.ReadLine();
//        }
//    }
//}

/// <summary>
/// EXAMPLE OF ACCESSING PRIVATE VARIABLE USING GET SET PROPERTY...FORGET THE CLASS NAMES, I CHANGED THE CODE AROUND A BIT
/// </summary>
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            childUnherited chUn = new childUnherited();
//            chUn.print();
//        }
//    }

//    class child
//    {
//        private int intNum;
//        public int Number1
//        {
//            get
//            {
//                return intNum;
//            }
//            set
//            {
//                intNum = value;
//            }
//        }
//    }
//    class childUnherited : child
//    {

//        public void print()
//        {
//            Number1 = Number1 + 2; //referencing ex below, the private intNum can now be accessed do to get set property
//            Console.WriteLine(Number1);
//        }
//    }
//}

/// <summary>
/// EXAMPLE OF TRYING TO ACCESS A PRIVATE VARIABLE IN ANOTHER CLASS - CAN'T DO IT
/// </summary>
//    class Program 
//    {
//        static void Main(string[] args)
//        {
//            child ch = new child();
//            ch.print();
//            childUnherited chUn = new childUnherited();
//            chUn.print();
//        }
//    }

//    class child 
//    {
//        private int intNum;

//        public void print()
//        {
//            intNum = intNum + 2;
//            Console.WriteLine(intNum);
//        }

//    }
//    class childUnherited : child
//    {

//         new void print()
//        {
//            intNum = intNum + 2; // beacause intNum in base class (child) is private this class cannot access it unless do a get set
//            Console.WriteLine(intNum);
//        }
//    }
//}
/// <summary>
/// EXAMPLE OF ACCESSING PRIVATE VARIABLES VIA GET SET PROPERTY
/// </summary>
//    class input
//    {
//        private int intNum, intNum2, intResult; //class doesn't have to be private, only the variables. These variables are private within the input class
//        public void add() // method for writing to the console
//        {
//            intResult = intNum + intNum2;
//            Console.WriteLine("\t Result = {0}", intResult);
//            Console.ReadLine();
//        }
//        public int Number1 //creating property for storing value in intNum
//        {
//            get
//            {
//                return intNum;
//            }
//            set
//            {
//                intNum = value;
//            }
//        }
//        public int Number2 //creating property for storing value in intNum2
//        {
//            get
//            {
//                return intNum2;
//            }
//            set
//            {
//                intNum2 = value;
//            }
//        }

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            input inp = new input(); //creating a new instance
//            Console.WriteLine("Enter first number to be added: ");
//            inp.Number1 = Int32.Parse(Console.ReadLine()); //using get set property to grab private variables

//            Console.WriteLine("Enter second number: ");
//            inp.Number2 = Int32.Parse(Console.ReadLine());

//            inp.add(); //calling add() method to perform addition

//        }
//    }
//}
/// <summary>
/// /EXAMPLE OF USING A PRIVATE VARIABLE IN SAME CLASS
/// </summary>
//    class Program
//    {
//        private void add()
//        {
//            int intNum = 2;
//            Console.WriteLine("Using a private variable in same class " + intNum);
//        }
//        static void Main(string[] args)
//        {
//            Program p = new Program();
//            p.add();
//            Console.ReadLine();
//        }
//    }
//}
/// <summary>
/// EXAMPLE OF A PYRAMID TOUGH ONE!!!!////
/// </summary>
//class Program
//{


//        static void Main(string[] args) //learning moment...Get a good visual of what you are trying to program BEFORE trying to write code. I convinced myself the reverse triangle COULD
//                                        // NOT contain a space for the first loop. BUT actually the first loop needed a space. Then ALL the different codes would have worked. :/
//        {
//            int intLayers = 9, intSpace, intNum, j;

//            for (j = 1; j <= intLayers; j++) //always try to use variables in loops if possible like j in rest of program. NOT declare new variables. 
//                                             //Overall loop that tells how many rows/layers deep to go
//            {
//                for (intSpace = 1; intSpace <= (intLayers - j); intSpace++) // neat little trick to enter in spaces
//                {
//                    Console.Write(" ");
//                }
//                for (intNum = 1; intNum <= j; intNum++) //increasing #
//                {
//                    Console.Write(intNum);
//                }
//                for (intNum = (intNum - 2); intNum >= 1; intNum--) // decreasing #
//                {
//                    Console.Write(intNum);
//                }
//                Console.WriteLine();
//            }

//            //reversing the triangle to create a pyramid

//            for (j = (intLayers - 1); j >= 1; j--)
//            {
//                for (intSpace = 0; intSpace < (intLayers - j); intSpace++) // neat little trick to enter in spaces
//                {
//                    Console.Write(" ");
//                }
//                for (intNum = 1; intNum <= j; intNum++) //increasing #
//                {
//                    Console.Write(intNum);
//                }
//                for (intNum = (intNum - 2); intNum >= 1; intNum--) // decreasing #
//                {
//                    Console.Write(intNum);
//                }
//                Console.WriteLine();
//            }
//            Console.ReadLine();
//        }
//    }


//}
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
