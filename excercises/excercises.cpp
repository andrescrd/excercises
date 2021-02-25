#include <iostream>
#include <ostream>
#include "BinaryGap/binary_gap.h"

int main()
{
    std::cout << "Gap 9: " << binary_gap::get_max_gap(9) << std::endl;
    std::cout << "Gap 529: " << binary_gap::get_max_gap(529) << std::endl;
    std::cout << "Gap 20: " << binary_gap::get_max_gap(20) << std::endl;
    std::cout << "Gap 15: " << binary_gap::get_max_gap(15) << std::endl;
    std::cout << "Gap 32: " << binary_gap::get_max_gap(32) << std::endl;
    std::cout << "Gap 1041: " << binary_gap::get_max_gap(1041) << std::endl;

    return 0;
}
