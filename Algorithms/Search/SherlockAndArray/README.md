Sherlock and Array
==================
[Русский](https://www.hackerrank.com/external_redirect?to=https://hr-filepicker.s3.amazonaws.com/101may14/russian/2490-sherlock-and-array.pdf) | [中文](https://www.hackerrank.com/external_redirect?to=https://hr-filepicker.s3.amazonaws.com/101may14/chinese/2490-sherlock-and-array.pdf)

Watson gives Sherlock an array **A** of length **n**. Then he asks him to determine if there exists an element in the array such that the sum of the elements on its left is equal to the sum of the elements on its right. If there are no elements to the left/right, then the sum is considered to be zero. 
Formally, find an **i**, such that, **A0 + A1 + ... + Ai+1 = Ai+1 + Ai+2 + ... + An-1**.

#### Input Format

The first line contains **T**, the number of test cases. For each test case, the first line contains **n**, the number of elements in the array **A**. The second line for each test case contains **n** space-separated integers, denoting the array **A**.

#### Constraints

 **1 <= T <= 10**<br>
 **1 <= n <= 10^5**<br>
 **1 <= Ai <= 2 x 10^4**<br> 
 **1 <= i <= N**
 
#### Output Format

For each test case print ```YES``` if there exists an element in the array, such that the sum of the elements on its left is equal to the sum of the elements on its right; otherwise print ```NO```.

#### Sample Input 0
```
2
3
1 2 3
4
1 2 3 3
```
#### Sample Output 0
```
NO
YES
```
#### Explanation 0

For the first test case, no such index exists. 
For the second test case, , therefore index  satisfies the given conditions.
<br>
<br>
#### Reference: [HackerRank](https://www.hackerrank.com/challenges/sherlock-and-array)
