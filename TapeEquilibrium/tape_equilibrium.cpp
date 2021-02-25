#include "tape_equilibrium.h"

int tape_equilibrium::solution(std::vector<int>& A)
{
    if (A.empty())
        return 0;

    int right = 0;
    int left = A[0];
    const int size = A.size();

    for (int i = 1; i < size; ++i)
        right += A[i];

    int ans = abs(left - right);
    
    for (int i = 1; i < size; ++i)
    {
        ans = abs(left - right) < ans ? abs(left - right) : ans;
        left += A[i];
        right -= A[i];
    }

    return ans;
}
