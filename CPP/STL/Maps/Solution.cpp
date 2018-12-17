#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <set>
#include <map>
#include <algorithm>
#include <string>

using namespace std;

int main()
{
    int Q;
    cin >> Q;

    map<string, int> map;

    for (int i = 0; i < Q; i++)
    {
        int type;

        string x;
        int y;

        cin >> type;
        cin >> x;

        int temp;
        switch (type)
        {
        case 1:
            cin >> y;

            temp = map[x];
            map.erase(x);
            map.insert(make_pair(x, y + temp));
            break;

        case 2:
            map.erase(x);
            break;

        case 3:
            cout << map[x] << endl;
            break;
        }
    }

    return 0;
}
