#include <iostream>

using namespace std;

void update(int *a, int *b)
{
    int tempA = *a;

    *a = *a + *b;
    *b = abs(tempA - *b);
}

int main()
{
    int a, b;
    cin >> a >> b;

    update(&a, &b);

    cout << a << endl;
    cout << b << endl;

    return 0;
}
