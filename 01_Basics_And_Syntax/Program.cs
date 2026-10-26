using System;

namespace BasicsAndSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string? input = Console.ReadLine();

            if(int.TryParse(input, out int age))
            {
                Console.WriteLine("Parsing has been done successfully!"); //Do not forget that parse can convert only from string! For flexibility you can use Convert keyword.
            }
            else
            {
                Console.WriteLine("Invalid data conversion had been tried by the user! You have to enter an integer as your input.");
            }

            Console.WriteLine("What is your gpa?");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your balance?");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"---INFO---\nName: {name}\nAge: {age}\nGPA: {gpa:F2}\nBalance: {balance:C}");

        }
    }
}