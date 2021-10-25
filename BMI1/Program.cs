using System;

namespace BMI1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI CALCULATION");
            Console.ReadLine();

            double Weight;
            double Height;
            double count;
           
            Console.WriteLine("Enter your Weight");
            double.TryParse(Console.ReadLine(), out Weight);
            if (Weight < 50)
                Console.WriteLine($"Invalid Weight");
            Console.ReadLine();
        
            Console.WriteLine("Enter your Height");
            double.TryParse(Console.ReadLine(), out Height);
            if (Height < 120)
                Console.WriteLine($"Invalid Height");
            Console.ReadLine();
            
            count  = (Weight) / (Height/100*Height/100);
            count = Math.Round(count, 2);
            if (count < 16)
            { Console.WriteLine($"Your BMI is{ count }, You are extremely underweight"); }
            if (count >= 16 & count <= 20)
            { Console.WriteLine($"Your BMI is{ count }, You are underweight"); }
            if (count  >= 20 & count <= 25 )
            Console.WriteLine($"Your BMI is{ count }, You are normal");
            if (count >= 25 & count <= 30)
            Console.WriteLine($"Your BMI is{ count }, You are overweight");
            if (count >= 30 & count <= 35)
            Console.WriteLine($"Your BMI is{ count }, You are obese");
            if(count > 35)
            Console.WriteLine($"Your BMI is{ count }, You are extremely obese");


        }
    }
}