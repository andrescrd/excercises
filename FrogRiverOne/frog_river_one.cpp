#include "frog_river_one.h"

#include <set>
#include <vector>

int frog_river_one::solution(const int X, std::vector<int>& A)
{
    std::set<int> s;
    for (auto i = 0; i < A.size(); i++)
    {
        s.insert(A[i]);
        if (s.size() == X) return i;
    }

    return -1;
}
