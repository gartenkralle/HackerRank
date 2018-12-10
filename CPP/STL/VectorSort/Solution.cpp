#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    int N;
    int number;

    vector<int> v;

    cin >> N;

    for (int i = 0; i < N; i++)
    {
        cin >> number;
        v.push_back(number);
    }

    sort(v.begin(), v.end());

    for (int i = 0; i < N; i++)
    {
        cout << v.at(i) << " ";
    }

    return 0;
}
