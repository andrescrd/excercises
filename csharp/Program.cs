﻿using System;

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
            Console.WriteLine($"CyclicRotation: {string.Join('-', result)}");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"OddOccurrencesInArray: {OddOccurrencesInArray.Solution(new[] {1, 1, 2, 2, 3, 4, 4})}");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"FrogJmp: {FrogJmp.Solution(10, 85, 30)}");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"PermMissingElem: {PermMissingElem.Solution(new[] {6, 7, 8, 1, 2, 4, 5})}");
            Console.WriteLine(Environment.NewLine);   
            
            Console.WriteLine($"TapeEquilibrium: {TapeEquilibrium.Solution(new[] {3,1,2,4,3})}");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"FrogRiverOne: {FrogRiverOne.Solution(5,new[] {1,3,1,4,2,3,6,5,4})}");
            Console.WriteLine(Environment.NewLine);

            var maxCounter = MaxCounters.Solution(5, new[] {3, 4, 4, 6, 1, 4, 4});
            Console.WriteLine($"MaxCounters: {string.Join('-', maxCounter)}");
            Console.WriteLine(Environment.NewLine);
        }
    }
}