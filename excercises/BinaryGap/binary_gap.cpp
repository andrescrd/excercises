#include "binary_gap.h"

#include <bitset>

std::string binary_gap::get_binary(const int num)
{
    const size_t sub = std::bitset<64>(num).to_string().find("1");
    return  std::bitset<64>(num).to_string().substr(sub);
}

int binary_gap::get_max_gap(const int num)
{
    if(num <= 0)
        return 0;
    
    int current_gap = 0;
    int gap = 0;

    std::string binary = get_binary(num);

    for (int count = 1; count < binary.length(); count++)
    {
        if (binary[count] == '0')
        {
            current_gap++;
        }
        else
        {
            if (current_gap > gap)
                gap = current_gap;

            current_gap = 0;
        }
    }

    return gap;
}
