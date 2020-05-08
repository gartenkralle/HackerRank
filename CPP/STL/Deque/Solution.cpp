#include <iostream>
#include <deque>

using namespace std;

void constructDeque(deque<int>* maxMinDeque, int arr[], int n, int i, int k)
{
    while (!maxMinDeque->empty() && (maxMinDeque->back() <= i - k || arr[maxMinDeque->back()] <= arr[i]))
    {
        maxMinDeque->pop_back();
    }

    while (!maxMinDeque->empty() && maxMinDeque->front() <= i - k)
    {
        maxMinDeque->pop_front();
    }

    if (maxMinDeque->empty() || arr[i] > arr[maxMinDeque->front()])
    {
        maxMinDeque->push_front(i);
    }
    else if (maxMinDeque->empty() || arr[i] < arr[maxMinDeque->back()])
    {
        maxMinDeque->push_back(i);
    }
}

void printKMax(int arr[], int n, int k)
{
    deque<int> maxMinDeque{ 0 };

    for (int i = 1; i < k; i++)
    {
        constructDeque(&maxMinDeque, arr, n, i, k);
    }

    cout << arr[maxMinDeque.front()] << " ";

    for (int i = k; i < n; i++)
    {
        constructDeque(&maxMinDeque, arr, n, i, k);
        cout << arr[maxMinDeque.front()] << " ";
    }

    cout << endl;
}

int main()
{
    int t;
    cin >> t;

    while (t > 0)
    {
        int n, k;
        cin >> n >> k;
        int i;

        int* arr = new int[n];

        for (i = 0; i < n; i++)
            cin >> arr[i];

        printKMax(arr, n, k);

        t--;
    }

    return 0;
}
