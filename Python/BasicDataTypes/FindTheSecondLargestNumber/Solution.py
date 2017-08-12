if __name__ == '__main__':
    n = int(input())
    arr = list(map(int, input().split()))
    
    maxValue = max(arr)

    while(maxValue in arr):
        arr.remove(maxValue)

    print(max(arr))
