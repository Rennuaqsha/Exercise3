using System;
using System.Runtime.Versioning;
using System.Xml;

namespace Exercise_linked_list_A
{
    class node
    {
        /*creates Nodes for the circular nexted list*/
        public int rollNumber;
        public string name;
        public node next;
    }
    class CircularList
    {
        node Last;

        public CircularList()
        {
            Last = null;
        }
        public bool Search(int rollNo, ref previous, ref node current)
        /*Searches for the specified node*/
        {
            for (previous = current = Last.next; current != Last; previous = current,
                 current = current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true); /*return true if the node is found*/
            }
            if (rollNo == Last.rollNumber)/*if the node is present at the end*/
                return true;
            else
                return (false);/*return false if the node is not found*/ 
        }
        public bool listEmpty()
        {
            if (Last == null)
                return true;
            else 
                return false;
        }

        public void traverse()/*traverses all the nodes of the list*/
        {
            if (listEmpty())
                Console.WriteLine("nlist is empty");
            else
            {
                Console.WriteLine("\nRecords in the list are : \n");
                node currentNode;
                currentNode = Last.next;
                while (currentNode != Last)
                {
                    Console.Write(currentNode.rollNumber + " " + currentNode + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(Last.rollNumber + " " + Last.name + "n");
            }
        }
        public void FirstNode()
        {
            if (listEmpty())
                Console.WriteLine("\mList is empty");
            else
                Console.WriteLine("\nThe First record in the list is:\n\n" +
                    Last.next.rollNumber + " " + Last.next.name);
        }
    }
}
