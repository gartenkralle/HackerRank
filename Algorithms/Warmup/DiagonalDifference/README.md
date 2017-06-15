Diagonal Difference
===================
Given a square matrix of size , calculate the absolute difference between the sums of its diagonals.

#### Input Format

The first line contains a single integer, . The next  lines denote the matrix's rows, with each line containing space-separated integers describing the columns.

#### Constraints

#### Output Format

Print the absolute difference between the two sums of the matrix's diagonals as a single integer.

#### Sample Input
```
3
11 2 4
4 5 6
10 8 -12
```
#### Sample Output
```
15
```
#### Explanation

The primary diagonal is:
```
11
   5
     -12
     ```
Sum across the primary diagonal: 11 + 5 - 12 = 4

The secondary diagonal is:
```
     4
   5
10
```
Sum across the secondary diagonal: 4 + 5 + 10 = 19 
Difference: |4 - 19| = 15

Note: |x| is absolute value function
