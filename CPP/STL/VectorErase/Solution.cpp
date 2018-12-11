#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

void printVector(vector<int> v)
{
    for (unsigned int i = 0; i < v.size() - 1; i++)
    {
        cout << v[i] << ' ';
    }

    cout << v[v.size() - 1] << endl;
}

int main()
{
    int N;
    int x;
    int a, b;
    int number;

    vector<int> v;

    cin >> N;

    for (int i = 0; i < N; i++)
    {
        cin >> number;
        v.push_back(number);
    }

    cin >> x;
    cin >> a >> b;

    v.erase(v.begin() + x - 1);
    v.erase(v.begin() + a - 1, v.begin() + b - 1);

    cout << v.size() << endl;

    printVector(v);

    return 0;
}
