

#region ex

/*
 * 1.1   Suppose you have a sorted list of 128 names, and you’re searching 
through it using binary search. What’s the maximum number of 
steps it would take?

when we used the Binary search the maximum number of steps can be found using the logarithm function is (7).
the maximum steps = log2(128)  => 2*2*2*2*2*2*2 = 128 == 2^7
*/

/*
 *  1.2   Suppose you double the size of the list. What’s the maximum 
number of steps now?

For the initial list 128 names, we saw that the maximum steps were log2(128) ≈ 7 .

after  double the size of the list
128 * 2 = 256
 maximum steps = log2(256)   => log2(2^8)   ==  2^8 = 256    so the maximum steps is  = 8
*/



/*
 * 1.3   You have a name, and you want to find the person’s phone number 
in the phone book. 
we have tow away to find the person’s phone number 
in the phone book :

   if the names is sorted 
{
       using  Binary Search O(log2 n)
}
else
{
     using simple search O(n)
}

 */



/*
 * 1.4   You have a phone number, and you want to find the person’s name 
in the phone book. (Hint: You’ll have to search through the whole 
book!)?
            solution: Simple search O(n)
 */


/*
 * 1.5   You want to read the numbers of every person in the phone book.
 *           solution:   Simple search O(n)
 */

/*
 * 1.6   You want to read the numbers of just the As.
 * solution :  Simple search O(n)
 */

#endregion

#region  Big (o) Notation

#endregion


using Task2.LinkedList;

#region  linkedList
//1. Write a  c# program to create and display a Singly Linked List.

SinglyLinkedList<int> node = new SinglyLinkedList<int>();
node.Add(1);
node.Add(2);
node.Add(8);
node.Add(4);
node.DisplayList();


Node<int> currentNode = node.GetLinkedList(); //هنا مجرد مثود تجيبلي اللستة

//2.Write a c# program to create a singly linked list of n nodes and display it in reverse order.
node.DisplayReverseOrderList(currentNode); 


//  3. Write a  c# program to create a singly linked list of n nodes and count the number of nodes.
node.CountNodesInLinkedList(currentNode);

//  4. Write a  c# program to insert a node at any position in a Singly Linked List.
node.AddNodeInPosition(node: currentNode, postion:3 , data : 11);
#endregion
