#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

void calculate_the_maximum(int n, int k)
{
    int maxSumAnd = 0;
    int maxSumOr = 0;
    int maxSumXor = 0;

    for (int b = 2; b <= n; b++)
    {
        for (int a = 1; a < b; a++)
        {
            int sumAnd = a & b;
            int sumOr = a | b;
            int sumXor = a ^ b;

            if ((sumAnd < k) && (sumAnd > maxSumAnd))
                maxSumAnd = sumAnd;

            if ((sumOr < k) && (sumOr > maxSumOr))
                maxSumOr = sumOr;

            if ((sumXor < k) && (sumXor > maxSumXor))
                maxSumXor = sumXor;
        }
    }

    printf("%d\n",maxSumAnd);
    printf("%d\n", maxSumOr);
    printf("%d\n", maxSumXor);
}

int main()
{
    int n, k;

    scanf("%d %d", &n, &k);

    calculate_the_maximum(n, k);

    return 0;
}
