import math
import os
import random
import re
import sys

def solve(s):

    result = ""
    arr = s.split(' ')

    for word in arr:
        if(word == ''):
            result += " "
        else:
            result += word.capitalize() + " "

    return result

if __name__ == '__main__':
    s = input()

    result = solve(s)

    print(result + '\n')
