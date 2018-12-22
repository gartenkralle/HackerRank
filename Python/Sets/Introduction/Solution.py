from __future__ import division

def average(array):
    setResult = set(array)
    sumResult = sum(setResult)

    return sumResult / len(setResult)

if __name__ == '__main__':
    n = int(input())
    arr = map(int, input().split())
    result = average(arr)
    print(result)
