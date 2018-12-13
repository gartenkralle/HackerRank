#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int getBorderDistance(int n, int index)
{
    int mostDistance = ((2 * n) - 2) >> 1;

    return mostDistance - abs(mostDistance - index);
}

int main()
{
    int n;
    scanf("%d", &n);

    int size = ((2 * n) - 1);
    int currentNumber = n;

    for (int i = 0; i < size; i++)
    {
        int distance = getBorderDistance(n, i);

        for (int i = 0; i < distance; i++)
        {
            printf("%d ", currentNumber);
            currentNumber--;
        }

        for (int i = distance; i < (size - distance); i++)
        {
            printf("%d ", currentNumber);
        }

        for (int i = 0; i < distance; i++)
        {
            currentNumber++;
            printf("%d ", currentNumber);
        }

        printf("\n");
    }

    return 0;
}
