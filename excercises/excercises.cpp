#include <iostream>
#include <ostream>
#include <vector>

#include "BinaryGap/binary_gap.h"
#include "CyclicRotation/cyclic_rotation.h"
#include "OddOccurrencesInArray/odd_occurrences.h"

int main()
{
    std::cout << "Gap 9: " << binary_gap::solution(9) << std::endl;
    std::cout << "Gap 529: " << binary_gap::solution(529) << std::endl;
    std::cout << "Gap 20: " << binary_gap::solution(20) << std::endl;
    std::cout << "Gap 15: " << binary_gap::solution(15) << std::endl;
    std::cout << "Gap 32: " << binary_gap::solution(32) << std::endl;
    std::cout << "Gap 1041: " << binary_gap::solution(1041) << std::endl;


    std::vector<int>  test = {3,5,8,6,7}; 
    cyclic_rotation::solution(test,3);  

    for (int i = 0; i < test.size(); ++i)
        std::cout << test[i];

    std::vector<int>  test2 = {3,5,5,3,8,6,6,7,8}; 

   std::cout << "Odd : " <<  odd_occurrences::solution(test2) << std::endl;
    return 0;
}
