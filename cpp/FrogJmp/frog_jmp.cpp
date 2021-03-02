#include "frog_jmp.h"

int frog_jmp::solution(const int X, const int Y, const int D)
{
    const int distance = (Y - X);
    return (distance + (D - 1)) / D;
}
