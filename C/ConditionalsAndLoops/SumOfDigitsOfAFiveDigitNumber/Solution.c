#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main()
{

    int n;
    scanf("%d", &n);

    int sum = 0;

    for (int i = 0; i < 5; i++)
    {
        sum += n % 10;
        n /= 10;
    }

    printf("%d", sum);

    return 0;
}
