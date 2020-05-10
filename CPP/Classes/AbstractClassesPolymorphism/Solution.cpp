#include <iostream>
#include <vector>
#include <map>
#include <string>
#include <algorithm>
#include <set>
#include <cassert>

using namespace std;

struct Node 
{
    Node* next;
    Node* prev;
    int value;
    int key;
    Node(Node* p, Node* n, int k, int val) :prev(p), next(n), key(k), value(val) {};
    Node(int k, int val) :prev(NULL), next(NULL), key(k), value(val) {};
};

class Cache 
{

protected:
    map<int, Node*> mp; //map the key to the node in the linked list
    int cp;  //capacity
    Node* tail; // double linked list tail pointer
    Node* head; // double linked list head pointer
    virtual void set(int, int) = 0; //set function
    virtual int get(int) = 0; //get function
};

class LRUCache : public Cache
{

public:
    LRUCache(int cp)
    {
        this->cp = cp;
    }

    int get(int key)
    {
        auto it = mp.find(key);

        if (it != mp.end())
        {
            return mp[key]->value;
        }
        else
        {
            return -1;
        }
    }

    void set(int key, int value)
    {
        if (mp.empty())
        {
            Node* node = new Node(key, value);

            head = node;
            tail = node;

            mp[key] = node;
        }
        else
        {
            auto it = mp.find(key);

            if (it != mp.end())
            {
                Node* node = it->second;

                if (node == head)
                {
                    node->value = value;
                }
                else if (node == tail)
                {
                    node->value = value;
                    tail = tail->prev;
                    node->next = head;
                    head->prev = node;
                    tail->next = 0;
                    node->prev = 0;
                    head = node;
                }
                else
                {
                    node->value = value;
                    node->prev->next = node->next;
                    node->next->prev = node->prev;
                    node->prev = 0;
                    node->next = head;
                    head->prev = node;
                    head = node;
                }
            }
            else
            {
                Node* node = new Node(key, value);
                node->next = head;
                head->prev = node;
                head = node;

                mp[key] = node;

                if (mp.size() > cp)
                {
                    Node* node = mp[tail->key];
                    mp.erase(tail->key);
                    tail = tail->prev;
                    tail->next = 0;

                    delete node;
                }
            }
        }
    }
};

int main() 
{
    int n, capacity, i;
    cin >> n >> capacity;

    LRUCache l(capacity);

    for (i = 0; i < n; i++) 
    {
        string command;
        cin >> command;

        if (command == "get")
        {
            int key;
            cin >> key;
            cout << l.get(key) << endl;
        }
        else if (command == "set") 
        {
            int key, value;
            cin >> key >> value;
            l.set(key, value);
        }
    }

    return 0;
}
