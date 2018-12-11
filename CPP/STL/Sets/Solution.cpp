#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <set>
#include <algorithm>

using namespace std;

int main()
{
    set<int> s;

    int Q;
    int x, y;

    cin >> Q;

    for (int i = 0; i < Q; i++)
    {
        cin >> y;
        cin >> x;

        switch (y)
        {
        case 1:
            s.insert(x);
            break;

        case 2:
            s.erase(x);
            break;

        case 3:
            set<int>::iterator itr = s.find(x);

            if (itr != s.end())
            {
                cout << "Yes" << endl;
            }
            else
            {
                cout << "No" << endl;
            }
            break;
        }
    }

    return 0;
}
