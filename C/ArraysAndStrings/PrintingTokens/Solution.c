#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {

    char *s;

    s = (char *)malloc(1024 * sizeof(char));
    scanf("%[^\n]", s);

    s = (char *)realloc(s, strlen(s) + 1);

    for (int i = 0; i < strlen(s); i++)
    {
        if (s[i] != ' ')
            printf("%c", s[i]);
        else
            printf("\n");
    }

    return 0;
}
