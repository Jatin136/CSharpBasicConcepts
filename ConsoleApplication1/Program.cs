// Use using to declare namespaces and functions we wish to use
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2;
using System.IO;

/*
Multiline Comment
*/

// Delegates are used to pass methods as arguments to other methods
// A delegate can represent a method with a similar return type and attribute list
delegate double GetSum(double num1, double num2);

// ---------- ENUMS ----------
// Enums are unique types with symbolic names and associated values

public enum Temperature
{
    Freeze,
    Low,
    Warm,
    Boil
}

// ---------- STRUCT ----------
// A struct is a custom type that holds data made up from different data types
struct Customers
{
    private string name;
    private double balance;
    private int id;

    public void createCust(string n, double b, int i)
    {
        name = n;
        balance = b;
        id = i;
    }

    public void showCust()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Balance : " + balance);
        Console.WriteLine("ID : " + id);
    }
}

// Give our code a custom namespace
namespace ConsoleApplication1
{
    class Program
    {
        // Code in the main function is executed
        static void Main(string[] args)
        {
            // Prints string out to the console with a line break (Write = No Line Break)
            Console.WriteLine("What is your name : ");

            // Accept input from the user
            string name = Console.ReadLine();

            // You can combine Strings with +
            Console.WriteLine("Hello " + name);

            // ---------- DATA TYPES ----------
            MoreConcepts.DataTypes();

            // ---------- MATH ----------
            MoreConcepts.MathMethods();


            // ---------- CONDITIONALS ----------

            MoreConcepts.Conditionals();

            // ---------- Looping ----------
            MoreConcepts.loops();

            // ---------- STRINGS ----------
            MoreConcepts.StringConcept();

            // ----------STRINGBUILDER----------
            MoreConcepts.StringBuilder();

            // ---------- ARRAYS ----------
            MoreConcepts.Arrays();

            // ---------- LISTS ----------
            MoreConcepts.List();

            // ---------- EXCEPTION HANDLING ----------
            MoreConcepts.Exception();

            // ---------- CLASSES & OBJECTS ----------

            Animal bulldog = new Animal(13, 50, "Spot", "Woof");

            Console.WriteLine("{0} says {1}", bulldog.Name, bulldog.sound);

            // Console.WriteLine("No. of Animals " + Animal.getNumOfAnimals());

            // ---------- ENUMS ----------

            Temperature micTemp = Temperature.Low;
            Console.Write("What Temp : ");

            Console.ReadLine();

            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;

                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;

                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;

                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }

            // ---------- STRUCTS ----------
            Customers bob = new Customers();

            bob.createCust("Bob", 15.50, 12345);

            bob.showCust();

            // ---------- ANONYMOUS METHODS ----------
            // An anonymous method has no name and its return type is defined by the return used in the method

            GetSum sum = delegate (double num1, double num2) {
                return num1 + num2;
            };

            Console.WriteLine("5 + 10 = " + sum(5, 10));

            // ---------- LAMBDA EXPRESSIONS ----------
            // A lambda expression is used to act as an anonymous function or expression tree

            // You can assign the lambda expression to a function instance
            Func<int, int, int> getSum = (x, y) => x + y;
            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));

            // Get odd numbers from a list
            List<int> numList = new List<int> { 5, 10, 15, 20, 25 };

            // With an Expression Lambda the input goes in the left (n) and the statements go on the right
            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();

            foreach (int num in oddNums)
            {
                Console.Write(num + ", ");
            }

            // ---------- FILE I/O ----------
            // The StreamReader and StreamWriter allows you to create text files while reading and 
            // writing to them

            string[] custs = new string[] { "Tom", "Paul", "Greg" };

            using (StreamWriter sw = new StreamWriter("custs.txt"))
            {
                foreach (string cust in custs)
                {
                    sw.WriteLine(cust);
                }
            }

            string custName = "";
            using (StreamReader sr = new StreamReader("custs.txt"))
            {
                while ((custName = sr.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }

            Console.Write("Hit Enter to Exit");
            string exitApp = Console.ReadLine();

        }
    }
}