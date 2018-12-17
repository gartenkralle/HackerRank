#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

class Person
{
protected:
    char name[100];
    int age;

public:
    virtual void getdata()
    {
        cin >> name >> age;
    }

    virtual void putdata()
    {
        cout << name << " " << age;
    }
};

class Professor : public Person
{
    static int id;

    int cur_id = 0;
    int publications;

public:
    Professor()
    {
        id++;
        cur_id = id;
    }

    void getdata()
    {
        cin >> name >> age >> publications;
    }

    void putdata()
    {
        cout << name << " " << age << " " << publications << " " << cur_id << endl;
    }
};

class Student : public Person
{
    static int id;
    int cur_id = 0;
    int marks[6];

public:
    Student()
    {
        id++;
        cur_id = id;
    }

    void getdata()
    {
        cin >> name >> age;

        for (int i = 0; i < 6; i++)
        {
            cin >> marks[i];
        }
    }

    void putdata()
    {
        int sum = 0;

        for (int i = 0; i < 6; i++)
        {
            sum += marks[i];
        }

        cout << name << " " << age << " " << sum << " " << cur_id << endl;
    }
};

int Professor::id;
int Student::id;

int main()
{
    int n, val;
    cin >> n;

    Person **per = (Person **)malloc(n * sizeof(Person *));

    for (int i = 0; i < n; i++)
    {
        cin >> val;

        if (val == 1)
        {
            per[i] = new Professor();
        }
        else
        {
            per[i] = new Student();
        }

        per[i]->getdata();
    }

    for (int i = 0; i < n; i++)
        per[i]->putdata();

    return 0;
}
