using System;

namespace excercises
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine($"Gap is {BinaryGap.Solution(9)}");
            Console.WriteLine($"Gap is {BinaryGap.Solution(529)}");
            Console.WriteLine($"Gap is {BinaryGap.Solution(20)}");
            Console.WriteLine($"Gap is {BinaryGap.Solution(15)}");
            Console.WriteLine($"Gap is {BinaryGap.Solution(32)}");
            Console.WriteLine($"Gap is {BinaryGap.Solution(1041)}");
            
            Console.WriteLine(Environment.NewLine);

            var result = CyclicRotation.Solution(new[] {1, 2, 3, 4}, 2);
            Console.WriteLine($"Rotation: {string.Join('-',result)}");

        }
    }
}