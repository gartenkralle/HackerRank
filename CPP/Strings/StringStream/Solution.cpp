#include <sstream>
#include <vector>
#include <iostream>

using namespace std;

vector<int> parseInts(string str)
{
    vector<int> v;

    stringstream ss;
    ss.str(str);

    int number;
    char c;

    while (ss >> number)
    {
        v.push_back(number);
        ss >> c;
    }

    return v;
}

int main()
{
    string str;

    cin >> str;

    vector<int> integers = parseInts(str);

    for (unsigned int i = 0; i < integers.size(); i++)
    {
        cout << integers[i] << endl;
    }

    return 0;
}
