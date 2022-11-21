using System;
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
    }
}
