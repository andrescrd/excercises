#include <iostream>
#include <ostream>
#include <vector>

#include "BinaryGap/binary_gap.h"
#include "CyclicRotation/cyclic_rotation.h"
#include "FrogJmp/frog_jmp.h"
#include "OddOccurrencesInArray/odd_occurrences.h"
#include "PermMissingElem/perm_missing_elem.h"

int main()
{
    // BinaryGap
    std::cout << "BinaryGap" << std::endl;
    std::cout << "Gap 9: " << binary_gap::solution(9) << std::endl;
    std::cout << "Gap 529: " << binary_gap::solution(529) << std::endl;

    std::cout << std::endl;

    // CyclicRotation
    std::cout << "CyclicRotation" << std::endl;
    std::vector<int> test = {3, 5, 8, 6, 7};
    cyclic_rotation::solution(test, 3);

    for (int i = 0; i < test.size(); ++i)
        std::cout << test[i]  << " " << std::flush;

    std::cout << std::endl << std::endl;

    // OddOccurrencesInArray
    std::cout << "OddOccurrencesInArray" << std::endl;
    std::vector<int> test2 = {3, 5, 5, 3, 8, 6, 6, 7,7, 8,84};
    std::cout << "Odd : " << odd_occurrences::solution(test2) << std::endl;

    std::cout << std::endl;

    // FrogJmp
    std::cout << "FrogJmp" << std::endl;
    std::cout <<  frog_jmp::solution(10,85,30) << std::endl;

    std::cout << std::endl;

    // FrogJmp
    std::cout << "PermMissingElem" << std::endl;
    std::vector<int> missing = {14,17,11,13,12,16};
    std::cout <<  perm_missing_elem::solution(missing) << std::endl;
    return 0;
}