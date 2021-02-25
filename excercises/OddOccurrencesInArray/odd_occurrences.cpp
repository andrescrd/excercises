#include "odd_occurrences.h"

int odd_occurrences::solution(std::vector<int>& A)
{
    const int size = A.size();
    int sum = 0;
    
    for (int i=0; i<size; i++) {
        sum ^= A[i];
    }
    
    return sum;
}
