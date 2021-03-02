using System;

namespace excercises
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine($"BinaryGap is {BinaryGap.Solution(9)}");
            Console.WriteLine($"BinaryGap is {BinaryGap.Solution(529)}");
            Console.WriteLine($"BinaryGap is {BinaryGap.Solution(20)}");
            Console.WriteLine($"BinaryGap is {BinaryGap.Solution(15)}");
            Console.WriteLine($"BinaryGap is {BinaryGap.Solution(32)}");
            Console.WriteLine($"BinaryGap is {BinaryGap.Solution(1041)}");
            
            Console.WriteLine(Environment.NewLine);
            var result = CyclicRotation.Solution(new[] {1, 2, 3, 4}, 2);
            Console.WriteLine($"CyclicRotation: {string.Join('-',result)}");    
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"OddOccurrencesInArray: {OddOccurrencesInArray.Solution(new[] {1, 1,2,2, 3, 4,4})}");

        }
    }
}