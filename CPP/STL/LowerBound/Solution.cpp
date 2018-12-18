#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    int N;
    cin >> N;

    vector<int> vec;

    for (int i = 0; i < N; i++)
    {
        int number;
        cin >> number;

        vec.push_back(number);
    }

    int Q;
    cin >> Q;

    for (int i = 0; i < Q; i++)
    {
        int query;
        cin >> query;

        vector<int>::iterator low = lower_bound(vec.begin(), vec.end(), query);
        int index = low - vec.begin();

        if (vec[index] == query)
            cout << "Yes " << index + 1 << endl;
        else
            cout << "No " << index + 1 << endl;
    }

    return 0;
}
