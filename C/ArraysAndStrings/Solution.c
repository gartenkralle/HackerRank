#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main()
{
    int n;
    scanf("%d\n", &n);
    
    int *a = (int *)malloc(n * sizeof(int));
    
    for (int i = 0; i < n; i++)
    {
        scanf("%d", &a[i]);
    }

    int sum = 0;

    for (int i = 0; i < n; i++)
    {
        sum += a[i];
    }

    printf("%d\n", sum);

    return 0;
}
