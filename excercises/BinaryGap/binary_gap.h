#pragma once
#include <xstring>

class binary_gap
{
protected:
    static std::string get_binary(int num);
public:

    static int get_max_gap(const int num);
};
