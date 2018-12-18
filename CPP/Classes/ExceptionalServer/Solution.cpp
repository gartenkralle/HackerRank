#include <iostream>
#include <exception>
#include <string>
#include <stdexcept>
#include <vector>
#include <cmath>

using namespace std;

class Server
{
private:
    static int load;

public:
    static int compute(long long A, long long B)
    {
        load += 1;

        if (A < 0)
        {
            throw std::invalid_argument("A is negative");
        }

        vector<int> v((int)A, 0);
        int real = -1, cmplx = (int)sqrt(-1);

        if (B == 0)
            throw 0;

        real = (int)(A / B)*real;

        int ans = v.at((int)B);

        return real + (int)A - (int)B * ans;
    }

    static int getLoad()
    {
        return load;
    }
};

int Server::load = 0;

int main()
{
    int T;
    cin >> T;

    while (T--)
    {
        long long A, B;
        cin >> A >> B;

        try
        {
            cout << Server::compute(A, B) << endl;
        }
        catch (invalid_argument e)
        {
            cout << "Exception: " << e.what() << endl;
        }
        catch (bad_alloc e)
        {
            cout << "Not enough memory" << endl;
        }
        catch (exception e)
        {
            cout << "Exception: vector::_M_range_check: __n (which is " << B << ") >= this->size() (which is " << A << ")" << endl;
        }
        catch (int)
        {
            cout << "Other Exception" << endl;
        }
    }

    cout << Server::getLoad() << endl;

    return 0;
}
