#include <iostream>
#include <string>

using namespace std;

class Person
{
private:
    string first_name_;
    string last_name_;

public:
    Person(const string& first_name, const string& last_name) : first_name_(first_name), last_name_(last_name)
    {

    }

    const string& get_first_name() const
    {
        return first_name_;
    }

    const string& get_last_name() const
    {
        return last_name_;
    }
};

ostream &operator<<(ostream &out, Person person)
{
    return cout << "first_name=" << person.get_first_name() << "," << "last_name=" << person.get_last_name();
}

int main()
{
    string first_name, last_name, event;
    cin >> first_name >> last_name >> event;

    auto p = Person(first_name, last_name);

    cout << p << " " << event << endl;

    return 0;
}
