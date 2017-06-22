Fibonacci Modified
==================
We define a modified Fibonacci sequence using the following definition:
```
Given terms ti and ti+1 where i E [1, inf), term ti+2 is computed using the following relation:
ti+2 = ti + (ti+1)^2
```
For example, if term **t(1) = 0** and **t(2) = 1**, term **t(3) = 0 + 1^2 = 1**, term **t(4) = 1 + 1^2 = 2**, term **t(5) = 1 + 2^2 = 5**, and so on.

Given three integers, **t1**, **t2**, and **n**, compute and print term  of a modified Fibonacci sequence.

**Note:** The value of  may far exceed the range of a -bit integer. Many submission languages have libraries that can handle such large results but, for those that don't (e.g., C++), you will need to be more creative in your solution to compensate for the limitations of your chosen submission language.

#### Input Format

A single line of three space-separated integers describing the respective values of **t1**, **t2**, and **n**.

#### Constraints
- **0 <= t1, t2 <=2**

- **3 <= n <= 20**

- **tn** may far exceed the range of a **64**-bit integer.
#### Output Format

Print a single integer denoting the value of term  in the modified Fibonacci sequence where the first two terms are  and .

#### Sample Input
```
0 1 5
```
#### Sample Output
```
5
```
#### Explanation

The first two terms of the sequence are  and , which gives us a modified Fibonacci sequence of . Because , we print term , which is .
<br>
<br>
#### Reference: [HackerRank](https://www.hackerrank.com/challenges/fibonacci-modified)
