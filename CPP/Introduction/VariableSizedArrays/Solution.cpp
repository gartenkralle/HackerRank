#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    string line;

    int n;
    int q;

    cin >> n;
    cin >> q;

    vector<vector<int>> jagged_array;

    for (int i = 0; i < n; i++)
    {
        vector<int> row;

        int number;
        int count;

        cin >> count;

        for (int i = 0; i < count; i++)
        {
            cin >> number;
            row.push_back(number);
        }

        jagged_array.push_back(row);
    }

    for (int k = 0; k < q; k++)
    {
        int i;
        int j;

        cin >> i;
        cin >> j;

        cout << jagged_array.at(i).at(j) << endl;
    }

    return 0;
}
