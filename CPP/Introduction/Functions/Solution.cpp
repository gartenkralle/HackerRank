#include <iostream>
#include <cstdio>

using namespace std;

int max_of_four(int a, int b, int c, int d)
{
    int big1, big2;
    int result;

    if (a > b)
        big1 = a;
    else
        big1 = b;

    if (c > d)
        big2 = c;
    else
        big2 = d;

    if (big1 > big2)
        result = big1;
    else
        result = big2;

    return result;
}

int main()
{
    int a, b, c, d;
    cin >> a >> b >> c >> d;

    int result = max_of_four(a, b, c, d);

    cout << result << endl;

    return 0;
}
