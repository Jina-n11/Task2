


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


// 5. Write a  c# program to insert a node at the beginning of a Singly Linked List.
node.AddFirstNode(7);
node.DisplayList();

// 6. Write a  c# program to insert a node at the end of a Singly Linked List.
node.AddLastNode(19);
node.DisplayList();
#endregion
