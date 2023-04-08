using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            //Console.WriteLine();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            // Task12();
            //Task13();
            //Task14();
            // Task15();
            // Task16();
             Task17();
           // Task19();



        }
        static void Task1()
        {
            Console.Write("Hello World!!");
            Console.Write("Hello World!!");
            Console.ReadKey();
        }
        static void Task2()
        {
            Console.WriteLine("Hello World!!");
            Console.WriteLine("Hello World!!");
            Console.ReadKey();
        }
        static void Task3()
        {
            int variable = 7;
            Console.WriteLine("Value is :");
            Console.Write(variable);
            Console.ReadKey();

        }
        static void Task4()
        {
            Console.WriteLine();
            string var = "Hadia Moosa";
            Console.WriteLine("Your Name is: ");
            Console.Write(var);
            Console.ReadKey();
        }
        static void Task5()
        {
            Console.WriteLine();
            char a = 'A';
            Console.WriteLine("Character is : ");
            Console.Write(a);
            Console.ReadKey();
        }
        static void Task6()
        {
            Console.WriteLine();
            float num = 2.25F;
            Console.WriteLine("Decimal is: ");
            Console.Write(num);
            Console.ReadKey();
        }
        static void Task7()
        {
            Console.WriteLine();
            string str_1 = Console.ReadLine();
            Console.WriteLine("You have input: ");
            Console.WriteLine(str_1);
            Console.ReadKey();
        }
        static void Task8()
        {
            Console.WriteLine();
            int num;
            string str_2 = Console.ReadLine();
            num = int.Parse(str_2);
            Console.WriteLine("You have inputted: ");
            Console.Write(num);
            Console.ReadKey();
        }
        static void Task9()
        {
            Console.WriteLine();
            float number;
            Console.WriteLine("Enter floating number: ");
            string num2 = Console.ReadLine();
            number = float.Parse(num2);
            Console.WriteLine("floting number is : ");
            Console.Write(number);
            Console.ReadKey();

        }
        static void Task10()
        {
            Console.WriteLine();
            float length;
            float area;
            string str;
            Console.WriteLine("Enter length : ");
            str = Console.ReadLine();
            length = float.Parse(str);
            area = length * length;
            Console.WriteLine("Area is: ");
            Console.Write(area);
            Console.ReadKey();
        }
        static void Task11()
        {
            Console.WriteLine();
            string input;
            float numbers;
            Console.WriteLine("Enter marks of student: ");
            input = Console.ReadLine();
            numbers = float.Parse(input);
            if (numbers > 50)
            {
                Console.WriteLine("You are passed!");
            }
            else if (numbers < 50)
            {
                Console.WriteLine("You are not passed!!");
            }
            Console.ReadKey();
        }
        static void Task12()
        {
            Console.WriteLine();
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("WELCOME JACK!!");

            }
            Console.ReadKey();
        }
        static void Task13()
        {
            int numb;
            int sum = 0;
            Console.Write("Enter number: ");
            numb = int.Parse(Console.ReadLine());
            while (numb != -1)
            {
                sum = sum + numb;
                Console.Write("Enter number: ");
                numb = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The total sum is {0}", sum);
            Console.ReadKey();

        }
        static void Task14()
        {
            int num;
            int sum = 0;
            do
            {
                Console.WriteLine("Enter number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            while (num != -1);
            {
                sum = sum + 1;
                Console.WriteLine("The total sum is {0}", sum);
                Console.ReadKey();

            }
        }
        static void Task15()
        {
            int[] numbers = new int[3];
            for (int idx = 0; idx < 3; idx++)
            {
                Console.WriteLine("Your number {0}:", idx + 1);
                numbers[idx] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            for (int idx = 0; idx < 3; idx++)
            {

                if (numbers[idx] > largest)
                {
                    largest = numbers[idx];

                }
            }
            Console.WriteLine("Largest number {0}: ", largest);
            Console.ReadKey();
        }
        static void Task16()
        {
            int num1;
            int num2;
            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            int result = add(num1, num2);
            Console.WriteLine("Sum is: {0} ", result);
            Console.ReadKey();
            ;

        }
        static int add(int n1, int n2)
        {
            return n1 + n2;
        }
        static void Task17()

        {
            int gifts =0;
            float totalmoneysaved = 0;
            int toys = 0;
            int toysP =0;
            int var = 0;
            Console.Write("Enter Lilli's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter washing machine price: ");
            float price = float.Parse(Console.ReadLine());
            Console.Write("Enter price of toy: ");
            int priceT = int.Parse(Console.ReadLine());
            Console.ReadKey();
            for (int i = 1; i <= age; i = i + 1)
            {
                if (i % 2 == 0)
                {
                    gifts = (gifts + 10);
                    var = gifts + var;
                    
                    

                }
                else if (i % 2 != 0)
                {
                    toys++;
                }
            }
            toysP = toys * priceT;
            totalmoneysaved = var + toysP - toys;
            if (totalmoneysaved > price)
            {
                float remain = 0;
                remain = totalmoneysaved - price;
                Console.WriteLine("YES!!" + remain + "left paisas");
            }

            else if (totalmoneysaved < price)
            {
                float more = 0;
                more = price - totalmoneysaved;
                Console.WriteLine("No!!" + more);
            } 
            Console.ReadKey(); 
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. SignIn ");
            Console.WriteLine("2.SignUp ");
            Console.WriteLine("Enter option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;

                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
                
            }
            return item;

        }
        static void ReadData(string path, string[] names, string[] passwords)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = ParseData(record, 1);
                    passwords[x] = ParseData(record, 2);
                    x++;

                    if (x >= 5)
                    {
                        break;
                    }

                }
                fileVariable.Close();
            }


            else
            {
                Console.WriteLine("Not Exists");
            }
        }
    
    static void SignIn(string n, string p, string[] names, string[] passwords)
    {
        bool flag = false;
        for (int x = 0; x < 5; x++)
        {
            if (n == names[x] && p == passwords[x])
            {
                Console.WriteLine("Valid user");
                flag = true;
            }
        }
        if (flag == false)
        {
            Console.WriteLine("Invalid user");
        }
        Console.ReadKey();
    }
    static void signUp(string path, string n, string p)
    {
        StreamWriter file = new StreamWriter(path, true);
        file.WriteLine(n + "," + p);
        file.Flush();
        file.Close();

    }
    static void Task19()
    {

        string path = "C:\\Users\\HAFSA MOOSA\\source\\repos\\work\\work\\source.txt";
        string[] names = new string[5];
        string[] passwords = new string[5];
        int option;

        do
        {

            ReadData(path, names, passwords);
            Console.Clear();
            option = menu();
            Console.Clear();
            if (option == 1)
            {
                Console.WriteLine("Enter name: ");
                string n = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string p = Console.ReadLine();
                SignIn(n, p, names, passwords);
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter name: ");
                string n = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string p = Console.ReadLine();
                signUp(path, n, p);
            }
        }
        while (option < 3);
        Console.Read();


    }

}

  }







            
           



        

      
