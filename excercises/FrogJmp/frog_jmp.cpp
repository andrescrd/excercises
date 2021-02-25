#include "frog_jmp.h"

#include <cmath>

int frog_jmp::solution(const int X, const int Y, const int D)
{
    const int distance = (Y - X);
    int jumps = distance / D;

    if (distance % D != 0)
        jumps++;

    return jumps;
}
