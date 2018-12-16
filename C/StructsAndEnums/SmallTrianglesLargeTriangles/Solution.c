#include <stdio.h>
#include <stdlib.h>
#include <math.h>

struct triangle
{
    int a;
    int b;
    int c;
};

typedef struct triangle triangle;

float getArea(triangle *triangle)
{
    float p = (float)(triangle->a + triangle->b + triangle->c) / 2;

    return sqrtf(p * (p - triangle->a) * (p - triangle->b) *(p - triangle->c));
}

void swap(triangle *triangles, int a, int b)
{
    triangle temp = triangles[a];
    triangles[a] = triangles[b];
    triangles[b] = temp;
}

void sort_by_area(triangle* tr, int n)
{
    for (int i = 0; i < (n - 1); i++)
    {
        for (int j = (i + 1); j < n; j++)
        {
            if (getArea(&tr[i]) > getArea(&tr[j]))
                swap(tr, i, j);
        }
    }
}

int main()
{
    int n;
    scanf("%d", &n);

    triangle *tr = (triangle *)malloc(n * sizeof(triangle));

    for (int i = 0; i < n; i++)
    {
        scanf("%d%d%d", &tr[i].a, &tr[i].b, &tr[i].c);
    }

    sort_by_area(tr, n);

    for (int i = 0; i < n; i++)
    {
        printf("%d %d %d\n", tr[i].a, tr[i].b, tr[i].c);
    }

    return 0;
}
