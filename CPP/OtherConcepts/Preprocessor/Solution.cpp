#define toStr(x) #x
#define io(v) cin >> v
#define FUNCTION(f, o) void f(int &m, int e){ if (e o m) m = e; }
#define INF 10000000
#define foreach(a,b) for(int i=0; i<n; i++)

#include <iostream>
#include <vector>

using namespace std;

#if !defined toStr || !defined io || !defined FUNCTION || !defined INF
#error Missing preprocessor definitions
#endif 

FUNCTION(minimum, < )
FUNCTION(maximum, > )

int main()
{
    int n; cin >> n;
    vector<int> v(n);

    foreach(v, i)
    {
        io(v)[i];
    }

    int mn = INF;
    int mx = -INF;

    foreach(v, i)
    {
        minimum(mn, v[i]);
        maximum(mx, v[i]);
    }

    int ans = mx - mn;
    cout << toStr(Result = ) << ' ' << ans;

    return 0;
}
