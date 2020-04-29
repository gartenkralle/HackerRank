#include <iostream>
#include <iomanip> 

using namespace std;

int main()
{
    int T;
    cin >> T;

    cout << setiosflags(ios::uppercase);
    cout << setw(0xf) << internal;

    while (T--)
    {
        double A; cin >> A;
        double B; cin >> B;
        double C; cin >> C;

        cout << std::setw(0) << std::showbase << std::fixed << std::nouppercase << std::hex << static_cast<unsigned long long>(A) << endl;

        std::cout.precision(2);
        cout << std::right << std::setfill('_') << std::setw(15) << std::showpos << B << endl;

        std::cout.precision(9);
        cout << std::uppercase << std::scientific << std::noshowpos << C << endl;
    }
}
