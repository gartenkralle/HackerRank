Intro to Tutorial Challenges
============================
#### About Tutorial Challenges 
Many of the challenges on HackerRank are difficult and assume that you already know the relevant algorithms very well. These tutorial challenges are different. They break down algorithmic concepts into smaller challenges, so that you can learn the algorithm by solving the challenges.

These challenges are intended for those who know some programming and now want to learn some algorithms. You could be a student majoring in Computers, a self-taught programmer, or an experienced developer who wants an active algorithms review!

The first series of challenges covers sorting. The challenges are listed below:

#### Tutorial Challenges - Sorting

Insertion Sort challenges
- Insertion Sort 1 - Inserting<br>
- Insertion Sort 2 - Sorting<br>
- Correctness and loop invariant<br>
- Running Time of Algorithms<br>
Quicksort challenges
- Quicksort 1 - Partition<br>
- Quicksort 2 - Sorting<br>
- Quicksort In-place (advanced)<br>
- Running time of Quicksort<br>
Counting sort challenges
- Counting Sort 1 - Counting<br>
- Counting Sort 2 - Simple sort<br>
- Counting Sort 3 - Preparing<br>
- Full Counting Sort (advanced)<br>
There will also be some challenges where you'll get to apply what you've learnt.

#### About the Challenges 
The challenges will describe some topic and then ask you to code a solution. As you progress through the challenges, you will learn some important concepts in algorithms. In each challenge, you will receive input on STDIN and you will need to print the correct output to STDOUT.

For many challenges, helper methods (like an array) will be provided for you to process the input into a useful format. You can use these methods to get started with your program, or you can write your own input methods if you want. Your code just needs to print the right output to each test case.

#### Sample Challenge 
This is a simple challenge to get things started. Given a sorted array () and a number (), can you print the index location of  in the array?

<i>The next section describes the input format. You can often skip it, if you are using included methods.<i>

#### Input Format 
There will be three lines of input:

**V** - the value that has to be searched.
**n** - the size of the array.
**ar - n** -  numbers that make up the array.
#### Output Format 
Output the index of **V** in the array.

<i>The next section describes the constraints and ranges of the input. You should check this section to know the range of the input.</i>

#### Constraints
- **1 <= n <= 1000**
- **-1000 <= V <= 1000, V E ar**
- It is guaranteed that **V** will occur in  exactly once.<br>
<i>This "sample" shows the first input test case. It is often useful to go through the sample to understand a challenge.</i>

#### Sample Input
```
4
6
1 4 5 7 9 12
```
#### Sample Output

```
1
```
#### Explanation 
**V = 4**. The value **4** is the **2**nd element in the array, but its index is **1** since array indices start from **0**, so the answer is **1**.
<br>
<br>
#### Reference: [HackerRank](https://www.hackerrank.com/challenges/tutorial-intro)
