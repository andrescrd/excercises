#include "cyclic_rotation.h"

std::vector<int> cyclic_rotation::solution(std::vector<int>& A, int K)
{
    if (A.empty() || A.size() == 1)
        return A;

    K = K % A.size();

    if (K == 0)
        return A;

    std::rotate(A.rbegin(), A.rbegin() + K, A.rend());
    return A;
}
