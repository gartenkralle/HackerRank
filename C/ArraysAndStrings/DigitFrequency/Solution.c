#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main()
{
    int numbers[10];

    for (int i = 0; i < 10; i++)
    {
        numbers[i] = 0;
    }

    char *num = (char *)malloc(1024);
    scanf("%s", num);

    num = (char *)realloc(num, (strlen(num) + 1) * sizeof(char));

    for (unsigned int i = 0; i < strlen(num); i++)
    {
        int index = num[i] - 48;

        if ((index >= 0) && (index <= 9))
        {
            numbers[index]++;
        }
    }

    for (int i = 0; i < 10; i++)
    {
        printf("%d ", numbers[i]);
    }

    return 0;
}
