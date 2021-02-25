#include "perm_missing_elem.h"

#include <algorithm>

int perm_missing_elem::solution(std::vector<int>& A)
{
    if (A.empty())
        return 1;

    std::sort(A.begin(), A.end());

    int num = A[0];
    
    for (int i = 0; i < A.size(); ++i)
    {
        if(A[i] != num)
            return num;

        num++;
    }

    return num;
}
