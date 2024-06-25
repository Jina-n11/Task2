using Task2.LinkedList;
using Task2.LinkedList.CommitHistory;
using Task2.PackageTask;



#region  Selection sort
/*
 *  Package
 * 
 * Write a C# function that takes a list of packages, where each package is represented by an object
 * with the properties Weight (an integer) and IsFragile (a boolean). Your function should sort the packages by weight in ascending order,
 * ensuring that all fragile packages appear after all non-fragile ones. Use the selection sort algorithm for sorting
 * 
 */
// create Package Class and add the data
Packages packages = new Packages();

packages.packages.Add( new Package(IsFragile: true, Weight: 37));
packages.packages.Add( new Package(IsFragile: false, Weight: 3));
packages.packages.Add( new Package(IsFragile: false, Weight: 7));
packages.packages.Add( new Package(IsFragile: false, Weight: 11));
packages.packages.Add( new Package(IsFragile: false, Weight: 31));
packages.packages.Add( new Package(IsFragile: false, Weight: 44));
packages.packages.Add( new Package(IsFragile: true, Weight: 8));

foreach (Package package in packages.packages)
{
    Console.WriteLine($"Fragile: {package.isFragile}  , weight:{package.weight}");
}

Console.WriteLine("#############");


// (Weight)جابلي هنا اوبجكت ال بكج مرتب حسب ال 
List<Package> sortPackagelist = packages.GetSortPackageList(packages.packages);

foreach (Package package in sortPackagelist)
{
    Console.WriteLine($"Weight:{package.weight} ,Fragile: {package.isFragile}");
}
Console.WriteLine("#############");


//  واطبعهم(Fragile) هنا افلتر اللستة مال بكج الي اجتي مرتبة حسب 
var fragileList = sortPackagelist.Where(x=> x.isFragile);
var nonFragileList = sortPackagelist.Where(x=> ! x.isFragile);

foreach (Package package in nonFragileList)
{
    Console.WriteLine($"Weight:{package.weight} ,Fragile: {package.isFragile}");
}

foreach (Package package in fragileList)
{
    Console.WriteLine($"Weight:{package.weight} ,Fragile: {package.isFragile}");
}
#endregion

Console.WriteLine("#####################################");






#region  linkedList

string typeLinkedList = TypeLinkedList.CommitHistory.ToString();

switch (typeLinkedList)
{

    case "CommitHistory":
        {
            #region CommitHistory
            CommitHistory<CommitData> commitHistory = new CommitHistory<CommitData>();
            CommitData commit = new CommitData( Message:"first commit" , Auther:"jinana@gmail.com");  

            commitHistory.Add(
                new CommitData( Message: "first commit", Auther: "jinana@gmail.com")
             );


            commitHistory.Add(
                new CommitData( Message: "second commit", Auther: "jinana2@gmail.com" , Id: "37")
                );


            commitHistory.Add(
                new CommitData( Message: "third commit", Auther: "jinana3@gmail.com")
                );

            commitHistory.Add(
        new CommitData(Message: "fourth commit", Auther: "jinana4@gmail.com")
        );

            commitHistory.DisplayList();
            Console.WriteLine("#####################################");

            var commitData = commitHistory.GetCommitById(id: "37");
            commitHistory.AddNewCommit(new CommitData(Message: "new commit", Auther: "jinana5@gmail.com"), referenceTo: commitData.id);
            commitHistory.DisplayList();
            Console.WriteLine("#####################################");

            var result = commitHistory.GetCommitByMessage(message: "first commit");
            commitHistory.AddNewCommit(new CommitData(Message: "the new commit", Auther: "jinana9@gmail.com"), referenceTo: result.id);
            commitHistory.DisplayList();
            Console.WriteLine("#####################################");
            #endregion
        }
        break;


    case "SinglyLinkedList": {

            #region  SinglyLinkedList

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
            node.AddNodeInPosition(node: currentNode, postion: 3, data: 11);
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
            Console.WriteLine(node.GetNode(index: 2));
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

        }
        break;

    case "DoublyLinkedList":
        {
            #region  DoublyLinkedList
            DoublyLinkedList<dynamic> node = new DoublyLinkedList<dynamic>();
            Console.WriteLine("//1. Write a  c# program to create and display a Doubly Linked List.");
            node.Add('a');
            node.Add('b');
            node.Add('c');
            node.Add("D:3");
            node.DisplayList();
            Console.WriteLine("####################################################");


            Node<dynamic> currentNode = node.GetLinkedList(); //هنا مجرد مثود تجيبلي اللستة

            Console.WriteLine("//2.Write a c# program to create a Doubly linked list of n nodes and display it in reverse order.");
            node.DisplayReverseOrder();
            Console.WriteLine("####################################################");


            Console.WriteLine("//  3. Write a  c# program to create a Doubly linked list of n nodes and count the number of nodes.\r\n");
            var countNode = node.count;
            Console.WriteLine($"Count the nodes in linledList = {countNode}");
            Console.WriteLine("####################################################");

            Console.WriteLine("// 4. Write a  c# program to insert a node at the beginning of a Doubly Linked List.\r\n");
            node.AddFirstNode("bbb");
            node.DisplayList();
            Console.WriteLine("####################################################");

            Console.WriteLine("// 5. Write a  c# program to get a node in an existing Doubly linked list.");
            // 7. Write a  c# program to get a node in an existing singly linked list.
            Console.WriteLine(node.GetNode(index: 2));
            Console.WriteLine("####################################################");


            Console.WriteLine("// 6. Write a  c# program to find the first index that matches a given element. Return -1 for no matching.");
            Console.WriteLine(node.GetIndexOfElement(data: 'j'));
            Console.WriteLine("####################################################");

  
            Console.WriteLine("//  7. Write a  c# program to insert a node at any position in a Doubly Linked List.");
            node.AddNodeInPosition(postion: 2, data: 'G');
            node.DisplayList();
            Console.WriteLine("####################################################");

            Console.WriteLine("//8. Write a  c# program that removes the node from the Doubly linked list at the specified index.");
            node.RemoveNodeInPosition(postion: 2);
            node.DisplayList();
            Console.WriteLine("####################################################");


            Console.WriteLine("//9. Write a  c# program to check whether a Doubly linked list is empty or not. Return true otherwise false.");
            Console.WriteLine(node.IsEmpty());
            Console.WriteLine("####################################################");


            Console.WriteLine("//  10. Write a  c# program to empty a Doubly linked list by pointing the head towards null.");
            node.DumpList();
            node.DisplayList();
            Console.WriteLine("####################################################");


            Console.WriteLine("//11. Write a  c# program that calculates the size of a Doubly Linked list..");
            var sizeList = node.count;
            Console.WriteLine($"Size the linledList is = {sizeList}");
            Console.WriteLine("####################################################");





            SinglyLinkedList<int> node2 = new SinglyLinkedList<int>();
            node2.Add(11);
            node2.Add(22);
            node2.Add(33);
            node2.Add(44);
            node2.Add(55);
            Console.WriteLine("// 12. Write a  c# program that removes the first element from a Doubly Linked list");
            node2.RemoveFirstElement();
            node2.DisplayList();
            Console.WriteLine("####################################################");


            Console.WriteLine("//13. Write a  c# program that removes the tail element from a Doubly Linked list. ");
            node2.RemoveLastElement();
            node2.DisplayList();
            Console.WriteLine("####################################################");

            #endregion
        }
        break;

}

#endregion
