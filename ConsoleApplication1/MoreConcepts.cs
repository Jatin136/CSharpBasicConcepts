using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MoreConcepts
    {
        /// <summary>
        /// ---------- DATA TYPES ----------
        /// </summary>
        public static void DataTypes()
        {
            // Booleans are true or false
            bool canVote = true;

            // Characters are single 16 bit unicode characters
            char grade = 'A';

            // Integer with a max number of 2,147,483,647
            int maxInt = int.MaxValue;

            // Long with a max number of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;

            // Decimal has a maximum value of 79,228,162,514,264,337,593,543,950,335
            // If you need something bigger look up BigInteger
            decimal maxDec = decimal.MaxValue;

            // A float is a 32 bit number with a maxValue of 3.402823E+38 with 7 decimals of precision
            float maxFloat = float.MaxValue;

            // A float is a 32 bit number with a maxValue of 1.797693134E+308 with 15 decimals of precision
            double maxDouble = double.MaxValue;

            // You can combine strings with other values with +
            Console.WriteLine("Max Int : " + maxDouble);

            // The dynamic data type is defined at run time 
            dynamic otherName = "Paul";
            otherName = 1;

            // The var data type is defined when compiled and then can't change
            var anotherName = "Tom";
            // ERROR : anotherName = 2;
            Console.WriteLine("Hello " + anotherName);

            // How to get the type and how to format strings
            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());
        }

        /// <summary>
        /// ---------- MATH ----------
        /// </summary>
        public static void MathMethods()
        {
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

            int i = 0;

            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i = " + (++i));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i = " + (--i));

            Console.WriteLine("i += 3 " + (i += 3));
            Console.WriteLine("i -= 2 " + (i -= 2));
            Console.WriteLine("i *= 2 " + (i *= 2));
            Console.WriteLine("i /= 2 " + (i /= 2));
            Console.WriteLine("i %= 2 " + (i %= 2));

            // Casting : If no magnitude is lost casting happens automatically, but otherwise it must be done
            // like this

            double pi = 3.14;
            int intPi = (int)pi; // put the data type to convert to between braces

            // Math Functions
            // Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sin, Sinh, Tan, Tanh
            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(number1) " + (Math.Abs(number1)));
            Console.WriteLine("Math.Ceiling(number1) " + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(number1) " + (Math.Floor(number1)));
            Console.WriteLine("Math.Max(number1, number2) " + (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(number1, number2) " + (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(number1, 2) " + (Math.Pow(number1, 2)));
            Console.WriteLine("Math.Round(number1) " + (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(number1) " + (Math.Sqrt(number1)));

            // Random Numbers
            Random rand = new Random();
            Console.WriteLine("Random Number Between 1 and 10 " + (rand.Next(1, 11)));
        }

        /// <summary>
        ///  ---------- CONDITIONALS ----------
        /// </summary>
        public static void Conditionals()
        {
            // Relational Operators : > < >= <= == !=
            // Logical Operators : && || ^ !

            // If Statement
            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true));

            // Ternary Operator

            bool canDrive = age >= 16 ? true : false;

            // Switch is used when you have limited options
            // Fall through isn't allowed with C# unless there are no statements between cases
            // You can't check multiple values at once

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");

                    // Goto can be used to jump to a label elsewhere in the code
                    goto Cute;
                default:
                    Console.WriteLine("Child");
                    break;
            }

            // Lable we can jump to with Goto
            Cute:
            Console.WriteLine("Toddlers are cute");
        }

        /// <summary>
        /// ---------- LOOPING ----------
        /// </summary>
        public static void loops()
        {
            int i = 0;

            while (i < 10)
            {
                // If i = 7 then skip the rest of the code and start with i = 8
                if (i == 7)
                {
                    i++;
                    continue;
                }

                // Jump completely out of the loop if i = 9
                if (i == 9)
                {
                    break;
                }

                // You can't convert an int into a bool : Print out only odds
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            // The do while loop will go through the loop at least once
            string guess;
            do
            {
                Console.WriteLine("Guess a Number ");
                guess = Console.ReadLine();
            } while (!guess.Equals("15")); // How to check String equality

            // Puts all changes to the iterator in one place
            for (int j = 0; j < 10; j++)
            {
                if ((j % 2) > 0)
                {
                    Console.WriteLine(j);
                }
            }

            // foreach cycles through every item in an array or collection
            string randStr = "Here are some random characters";

            foreach (char c in randStr)
            {
                Console.WriteLine(c);
            }
        }

        /// <summary>
        /// ---------- STRINGS ----------
        /// </summary>
        public static void StringConcept()
        {
            // Escape Sequences : \' \" \\ \b \n \t

            string sampString = "A bunch of random words";

            // Check if empty
            Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));
            Console.WriteLine("Is empty " + String.IsNullOrWhiteSpace(sampString));
            Console.WriteLine("String Length " + sampString.Length);

            // Find a string index (Starts with 0)
            Console.WriteLine("Index of bunch " + sampString.IndexOf("bunch"));

            // Get a substring
            Console.WriteLine("2nd Word " + sampString.Substring(2, 6));

            string sampString2 = "More random words";

            // Are strings equal
            Console.WriteLine("Strings equal " + sampString.Equals(sampString2));

            // Compare strings
            Console.WriteLine("Starts with A bunch " + sampString.StartsWith("A bunch"));
            Console.WriteLine("Ends with words " + sampString.EndsWith("words"));

            // Trim white space at beginning and end or (TrimEnd / TrimStart)
            sampString = sampString.Trim();

            // Replace words or characters
            sampString = sampString.Replace("words", "characters");
            Console.WriteLine(sampString);

            // Remove starting at a defined index up to the second index
            sampString = sampString.Remove(0, 2);
            Console.WriteLine(sampString);

            // Join values in array and save to string
            string[] names = new string[3] { "Matt", "Joe", "Paul" };
            Console.WriteLine("Name List " + String.Join(", ", names));

            // Formatting : Currency, Decimal Places, Before Decimals, Thousands Separator
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);

            Console.WriteLine(fmtStr.ToString());            
        }

        /// <summary>
        /// ---------- STRINGBUILDER ----------
        /// </summary>
        public static void StringBuilder()
        {
            
            // Each time you create a string you actually create another string in memory
            // StringBuilders are used when you want to be able to edit a string without creating new ones

            StringBuilder sb = new StringBuilder();

            // Append a string to the StringBuilder (AppendLine also adds a newline at the end)
            sb.Append("This is the first sentence.");

            // Append a formatted string
            sb.AppendFormat("My name is {0} and I live in {1}", "Jatin", "Mumbai");

            // Clear the StringBuilder
            // sb.Clear();

            // Replaces every instance of the first with the second
            sb.Replace("a", "e");

            // Remove characters starting at the index and then up to the defined index
            sb.Remove(5, 7);

            // Out put everything
            Console.WriteLine(sb.ToString());
        }

        /// <summary>
        /// ---------- ARRAYS ----------
        /// </summary>
        public static void Arrays()
        {            
            // Declare an array
            int[] randNumArray;

            // Declare the number of items an array can contain
            int[] randArray = new int[5];

            // Declare and initialize an array
            int[] randArray2 = { 1, 2, 3, 4, 5 };

            // Get array length
            Console.WriteLine("Array Length " + randArray2.Length);

            // Get item at index
            Console.WriteLine("Item 0 " + randArray2[0]);

            // Cycle through array
            for (int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, randArray2[i]);
            }

            // Cycle with foreach
            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }

            // Get the index of an item or -1
            Console.WriteLine("Where is 1 " + Array.IndexOf(randArray2, 1));

            string[] names = { "Tom", "Paul", "Sally" };

            // Join an array into a string
            string nameStr = string.Join(", ", names);
            Console.WriteLine(nameStr);

            // Split a string into an array
            string[] nameArray = nameStr.Split(',');

            // Create a multidimensional array
            int[,] multArray = new int[5, 3];

            // Create and initialize a multidimensional array
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            // Cycle through multidimensional array
            foreach (int num in multArray2)
            {
                Console.WriteLine(num);
            }

            // Cycle and have access to indexes
            for (int x = 0; x < multArray2.GetLength(0); x += 1)
            {
                for (int y = 0; y < multArray2.GetLength(1); y += 1)
                {
                    Console.WriteLine("{0} | {1} : {2}", x, y, multArray2[x, y]);
                }
            }
        }

        /// <summary>
        /// ---------- LISTS ----------
        /// </summary>
        public static void List()
        {
            
            // A list unlike an array automatically resizes

            // Create a list and add values
            List<int> numList = new List<int>();
            numList.Add(5);
            numList.Add(15);
            numList.Add(25);

            // Add an array to a list
            int[] randArray = { 1, 2, 3, 4, 5 };
            numList.AddRange(randArray);

            // Clear a list
            // numList.Clear();

            // Copy an array into a List
            List<int> numList2 = new List<int>(randArray);

            // Create a List with array
            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

            // Insert in a specific index
            numList.Insert(1, 10);

            // Remove a specific value
            numList.Remove(5);

            // Remove at an index
            numList.RemoveAt(2);

            // Cycle through a List with foreach or
            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }

            // Return the index for a value or -1
            Console.WriteLine("4 is in index " + numList3.IndexOf(4));

            // Does the List contain a value
            Console.WriteLine("5 in list " + numList3.Contains(5));

            // Search for a value in a string List
            List<string> strList = new List<string>(new string[] { "Tom", "Paul" });
            Console.WriteLine("Tom in list " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

            // Sort the List
            strList.Sort();
        }


        /// <summary>
        /// ---------- EXCEPTION HANDLING ----------
        /// </summary>
        public static void Exception()
        {
            // All the exceptions 
            // msdn.microsoft.com/en-us/library/system.systemexception.aspx#inheritanceContinued

            try
            {
                Console.Write("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} =  {1}", num, (10 / num));

            }

            // Specifically catches the divide by zero exception
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero");

                // Get additonal info on the exception
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);

                // Throw the exception to the next inline
                // throw ex;

                // Throw a specific exception
                // throw new InvalidOperationException("Operation Failed", ex);
            }

            // Catches any other exception
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
