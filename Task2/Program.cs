


using Task2.LinkedList;

#region  linkedList
Console.WriteLine("//1. Write a  c# program to create and display a Singly Linked List.");
SinglyLinkedList<int> node = new SinglyLinkedList<int>();
node.Add(1);
node.Add(2);
node.Add(8);
node.Add(4);
node.DisplayList();
Console.WriteLine("####################################################");


Node<int> currentNode = node.GetLinkedList(); //هنا مجرد مثود تجيبلي اللستة

Console.WriteLine("//2.Write a c# program to create a singly linked list of n nodes and display it in reverse order.");
node.DisplayReverseOrderList(currentNode);
Console.WriteLine("####################################################");


Console.WriteLine("//  3. Write a  c# program to create a singly linked list of n nodes and count the number of nodes.\r\n");
var countNode = node.CountNodesInLinkedList(currentNode);
Console.WriteLine($"Count the nodes in linledList = {countNode}");
Console.WriteLine("####################################################");


Console.WriteLine("//  4. Write a  c# program to insert a node at any position in a Singly Linked List.");
node.AddNodeInPosition(node: currentNode, postion:3 , data : 11);
Console.WriteLine("####################################################");


Console.WriteLine("// 5. Write a  c# program to insert a node at the beginning of a Singly Linked List.\r\n");
node.AddFirstNode(7);
node.DisplayList();
Console.WriteLine("####################################################");


Console.WriteLine("// 6. Write a  c# program to insert a node at the end of a Singly Linked List.\r\n");
node.AddLastNode(19); // as same add node
node.DisplayList();
Console.WriteLine("####################################################");


Console.WriteLine("// 7. Write a  c# program to get a node in an existing singly linked list.");
// 7. Write a  c# program to get a node in an existing singly linked list.
Console.WriteLine(node.GetNode(index: 9));
Console.WriteLine("####################################################");


Console.WriteLine("// 8. Write a  c# program to find the first index that matches a given element. Return -1 for no matching.");
Console.WriteLine(node.GetIndexOfElement(data: 8));
Console.WriteLine("####################################################");


Console.WriteLine("//9. Write a  c# program to check whether a single linked list is empty or not. Return true otherwise false.");
Console.WriteLine(node.IsEmpty());
Console.WriteLine("####################################################");


Console.WriteLine("//  10. Write a  c# program to empty a singly linked list by pointing the head towards null.");
node.DumpList();
node.DisplayList();
Console.WriteLine("####################################################");



Console.WriteLine("//11. Write a  c# program that removes the node from the singly linked list at the specified index.");
Console.WriteLine("####################################################");



Console.WriteLine("//12. Write a  c# program that calculates the size of a Singly Linked list..");
var sizeList = node.CountNodesInLinkedList(currentNode);
Console.WriteLine($"Size the linledList is = {sizeList}");
Console.WriteLine("####################################################");


SinglyLinkedList<int> node2 = new SinglyLinkedList<int>();
node2.Add(11);
node2.Add(22);
node2.Add(33);
node2.Add(44);
node2.Add(55);
Console.WriteLine("// 13. Write a  c# program that removes the first element from a Singly Linked list");
node2.RemoveFirstElement();
node2.DisplayList();
Console.WriteLine("####################################################");


Console.WriteLine("//  14. Write a  c# program that removes the tail element from a Singly Linked list. ");
node2.RemoveLastElement();
node2.DisplayList();
Console.WriteLine("####################################################");

#endregion
