
#region  Big (o) Notation

/* 1
 * This code computes the product of two variables, what is the runtime of this code?

int product(int a, int b) {
    int sum = 0;
    for (int I = 0; I < b; I++) {
        sum += a;       =>O(n)
    }
    return sum; 
}

solution: the run time for this code is O(n) Linear time complexity.
 * 
 */

/////////////////////////////////////////////////////////

/* 2
This code computes A ^ B, what would be the runtime?

static int power(int a, int b) {
    if (b < 0) return a;      => O(1)
    if (b == 0) return 1;     =>O(1)
    int sum = a;
    for (int I = 0; I < b - 1; I++) {
        sum *= a;             => O(n) 
    }
    return sum;
}
 solution: 
لوجود اللوب في الكود فان الرن تايم حيكون  
O(n) Linear time complexity
 */
/////////////////////////////////////////////////////////


/* 3
 * This code computes A% B, what would be the runtime?
 * 
int mod(int a, int b) {
    if (b <=a) return -1;   => O(1)
    int div = a / b;
    return a - div * b;      => O(1)
}
solution: the run time for this code is O(1).
 * 
 */
/////////////////////////////////////////////////////////


/* 4
 * This code computes a division between whole integers (assuming both are positive), what would be the runtime?

int div(int a, int b) {
    int count = a;
    int sum = b;
    while (sum <= a) {   => O(b/a)
        sum += b;  => O(n)
        count++;
    }
    return count;
}

 * solution: the run time for this code is O(n).
 */
/////////////////////////////////////////////////////////


/* 5
 * The following code calculates the square root of an integer. If the number is not a perfect square (there is no whole square root), then return -1. If N is 100, first guess if N is 50. Too high? Try something lower, halfway between 1 and 50, etc. What is the big-o?

int sqrt(int n) {
    return sqrt_helper(n, 1, n);
}
int sqrt_helper(int n, int min, int max) {
    if (max < min) return -1;   => O(1)
    int guess = (min + max) / 2;  => O(1)
    if (guess * guess == n) {
        return guess;  => O(1)
    } else if (guess *guess <n) {
        return sqrt_helper(n, guess + 1, max) ;   => log2(n)
    } else { 
        return sqrt_helper(n, min, guess - 1);  => log2(n)
    }
}
solution: the run time for this code is O(log(n)) because this code of binary search .
 * 
 */
/////////////////////////////////////////////////////////


/* 6
 * The following code calculates the square root of an integer. If the number is not a perfect square (there is no whole square root), then return -1. It does so by trying larger and larger numbers until it finds the correct value (or is too high). What is your runtime?

int sqrt(int n) {
    for (int guess = 1; guess * guess < n; guess++) {  => O(n)
        if (guess * guess == n) return guess;  => O(1)
    }
    return -1;
}

solution: the run time for this code is O(n).
 * 
 */
/////////////////////////////////////////////////////////



/* 7
 * If a binary search tree (BST) is not balanced, how long could it take in the worst case to find an item?
 * solution: the run time for this code is O(n). beacuse  the  binary search tree (BST) is not balanced.
 */
/////////////////////////////////////////////////////////


/* 8
 * What would be the worst case if we are looking for a value in a binary tree (Binary Tree - BT) that is not ordered?
 * solution : the worst case is O(n)
 */
/////////////////////////////////////////////////////////




/* 9
 * The appendToNew method adds a value to an array by creating a new, longer array and returning this longer array. How long does it take to copy the array?

int[] copyArray(int[] array) {
    int[] copy = new int[0];
    for (int value : array) {
        copy = appendToNew(copy, value);  => O(n)
    }
    return copy;
}
int[] appendToNew(int[] array, int value) {
    int[] bigger = new int[array.length + 1];
    for (int I = 0; I < array. length; I++) {
        bigger[I] = array[I];  => O(n)
    }
    bigger[bigger.length - 1] = value; 
    return bigger;
}
 الحل هلو 
O(n^2) لان هنا عندي لوبز متداخل بالاستدعاء
 * 
 */
/////////////////////////////////////////////////////////



/* 10
 * The following code adds the digits of a number. What is your runtime?

int sumDigits(int n) { 
    int sum = 0; 
    while (n > 0) { 
        sum += n % 10; 
        n /= 10; 
    } 
    return sum; 
} 
 solution: the run time for this code will be (O(log(n)) . لان ديقسمة للنص او اكثر في كلم مرة 
 * 
 */
/////////////////////////////////////////////////////////


#endregion
