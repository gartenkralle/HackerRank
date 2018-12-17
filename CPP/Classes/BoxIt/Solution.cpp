#include <stdio.h>
#include <string>
#include <iostream>

using namespace std;

//Overload operator << as specified
//ostream& operator<<(ostream& out, Box& B)

class Box
{
private:
    int l = 0;
    int b = 0;
    int h = 0;

public:
    Box()
    {

    }

    Box(int l, int b, int h)
    {
        this->l = l;
        this->b = b;
        this->h = h;
    }

    Box(const Box &box)
    {
        l = box.l;
        b = box.b;
        h = box.h;
    }

    int getLength()
    {
        return l;
    }

    int getBreath()
    {
        return b;
    }

    int getHeight()
    {
        return h;
    }

    long long CalculateVolume()
    {
        return (long long)l * b * h;
    }
};

bool operator<(Box &a, Box &b)
{
    return (a.getLength() < b.getLength()) ||
        ((a.getBreath() < b.getBreath()) && (a.getLength() == b.getLength())) ||
        ((a.getHeight() < b.getHeight()) && (a.getBreath() == b.getBreath()) && (a.getLength() == b.getLength()));
}

ostream &operator<<(ostream &out, Box box)
{
    return out << box.getLength() << " " << box.getBreath() << " " << box.getHeight();
}

void check2()
{
    int n;
    cin >> n;
    Box temp;

    for (int i = 0; i < n; i++)
    {
        int type;
        cin >> type;

        if (type == 1)
        {
            cout << temp << endl;
        }

        if (type == 2)
        {
            int l, b, h;
            cin >> l >> b >> h;

            Box NewBox(l, b, h);
            temp = NewBox;

            cout << temp << endl;
        }

        if (type == 3)
        {
            int l, b, h;
            cin >> l >> b >> h;

            Box NewBox(l, b, h);

            if (NewBox < temp)
            {
                cout << "Lesser\n";
            }
            else
            {
                cout << "Greater\n";
            }
        }

        if (type == 4)
        {
            cout << temp.CalculateVolume() << endl;
        }

        if (type == 5)
        {
            Box NewBox(temp);

            cout << NewBox << endl;
        }

    }
}

int main()
{
    check2();
}
