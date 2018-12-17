#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int sort_by_length(const char* a, const char* b);

int lexicographic_sort(const char* a, const char* b)
{
    int length = strlen(a) <= strlen(b) ? strlen(a) : strlen(b);

    for (int i = 0; i < length; i++)
    {
        if (a[i] - b[i] == 0)
            continue;
        else
            return a[i] - b[i];
    }

    if (strlen(a) != strlen(b))
        return sort_by_length(a, b);

    return 0;
}

int lexicographic_sort_reverse(const char* a, const char* b)
{
    if (lexicographic_sort(a, b) < 0)
        return 1;
    else if (lexicographic_sort(a, b) > 0)
        return -1;
    else
        return 0;
}

int get_number_of_distinct_characters(const char *s)
{
    int count = 0;

    int alphabet[26] = { 0 };

    for (unsigned int i = 0; i < strlen(s); i++)
    {
        alphabet[s[i] - 'a']++;
    }

    for (int i = 0; i < 26; i++)
    {
        if (alphabet[i] != 0)
            count++;
    }

    return count;
}

int sort_by_number_of_distinct_characters(const char* a, const char* b)
{
    int countA = get_number_of_distinct_characters(a);
    int countB = get_number_of_distinct_characters(b);

    return (countA == countB) ? lexicographic_sort(a, b) : (countA - countB);
}

int sort_by_length(const char* a, const char* b)
{
    int lengthDiffernce = strlen(a) - strlen(b);

    return lengthDiffernce == 0 ? lexicographic_sort(a, b) : lengthDiffernce;
}

void swap(char **arr, int a, int b)
{
    char *temp = arr[a];
    arr[a] = arr[b];
    arr[b] = temp;
}

void string_sort(char** arr, const int len, int(*cmp_func)(const char* a, const char* b))
{
    for (int i = 0; i < (len - 1); i++)
    {
        for (int j = (i + 1); j < len; j++)
        {
            if (cmp_func(arr[i], arr[j]) > 0)
                swap(arr, i, j);
        }
    }
}

int main()
{
    int n;
    scanf("%d", &n);

    char** arr = (char**)malloc(n * sizeof(char*));

    for (int i = 0; i < n; i++)
    {
        *(arr + i) = (char *)malloc(1024 * sizeof(char));
        scanf("%s", *(arr + i));
        *(arr + i) = (char *)realloc(*(arr + i), strlen(*(arr + i)) + 1);
    }

    string_sort(arr, n, lexicographic_sort);

    for (int i = 0; i < n; i++)
        printf("%s\n", arr[i]);

    printf("\n");

    string_sort(arr, n, lexicographic_sort_reverse);

    for (int i = 0; i < n; i++)
        printf("%s\n", arr[i]);

    printf("\n");

    string_sort(arr, n, sort_by_length);

    for (int i = 0; i < n; i++)
        printf("%s\n", arr[i]);

    printf("\n");

    string_sort(arr, n, sort_by_number_of_distinct_characters);

    for (int i = 0; i < n; i++)
        printf("%s\n", arr[i]);

    printf("\n");
}
